using NAudio.Wave;
using Spotify.Entity;
using Spotify.Services.Interfaces;
using System.Net;

namespace Spotify.Players
{
    public class Player
    {
        private readonly IMusicCollectionService musicCollectionService;
        private readonly ISongService songService;
        private readonly IRadioService radioService;
        public Player(IMusicCollectionService musicCollectionService, ISongService songService, IRadioService radioService)
        {
            this.musicCollectionService = musicCollectionService;
            this.songService = songService;
            this.radioService = radioService;
        }
        public void PlayRadio()
        {
            Console.Write("Enter Radio Id: ");
            if (!long.TryParse(Console.ReadLine(), out long radioId))
            {
                Console.WriteLine("Invalid Radio Id.");
                return;
            }

            Radio radio = radioService.GetRadioById(radioId);

            if (radio == null)
            {
                Console.WriteLine("Radio not found.");
                return;
            }

            try
            {
                var url = new Uri(radio.RadioUrl);
                var webRequest = (HttpWebRequest)WebRequest.Create(url);

                using (var response = webRequest.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    if (stream == null)
                    {
                        Console.WriteLine("Unable to get stream.");
                        return;
                    }

                    var waveOut = new WaveOutEvent();

                    using (var mp3Reader = new RawSourceWaveStream(stream, new Mp3WaveFormat(44100, 2, 0, 128000)))
                    {
                        waveOut.Init(mp3Reader);
                        waveOut.Play();

                        Console.WriteLine("Playback has started. Press Enter to stop.");

                        new Thread(() =>
                        {
                            while (waveOut.PlaybackState == PlaybackState.Playing)
                            {
                                Thread.Sleep(100);
                            }
                        }).Start();

                        Console.ReadLine();
                        waveOut.Stop();
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Network error.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Playback error.");
                Console.WriteLine(ex.Message);
            }
        }
        public void PlayMusicCollection()
        {
            Console.Write("Enter Music Collection Id: ");
            long musicCollectionId = long.Parse(Console.ReadLine());
            MusicCollection musicCollection = musicCollectionService.GetMusicCollectionById(musicCollectionId);

            foreach (var song in musicCollection.Songs)
            {
                Console.WriteLine($"There's a song playing right now: {song.Name}");
                PlayMusic(song);
            }
        }
        public void PlayMusic(Song song)
        {
            PlayerProcessor(song);
        }
        public void PlayMusic()
        {
            Console.Write("Enter song Id: ");
            long songId = Convert.ToInt64(Console.ReadLine());
            Song song = songService.GetSongById(songId);
            PlayerProcessor(song);
        }
        private void PlayerProcessor(Song song)
        {
            if (song == null)
            {
                Console.WriteLine("Song is null.");
                return;
            }

            Console.WriteLine($"Attempting to play song from: {song.FilePath}");

            if (!File.Exists(song.FilePath))
            {
                Console.WriteLine($"File not found: {song.FilePath}");
                return;
            }

            try
            {
                using (var audioFileReader = new AudioFileReader(song.FilePath))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFileReader);
                    outputDevice.Play();

                    Console.WriteLine("Playback has started. Press Enter to stop.");
                    new Thread(() =>
                    {
                        while (outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                            {
                                outputDevice.Stop();
                            }
                            Thread.Sleep(100);
                        }
                    }).Start();

                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(500);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio playback error.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

