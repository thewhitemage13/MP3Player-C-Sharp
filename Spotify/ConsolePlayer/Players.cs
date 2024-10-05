//using System;
//using System.IO;
//using System.Threading;
//using NAudio.Wave;
//using Spotify.Entities;
//using Spotify.Entity;
//using Spotify.Services;

//namespace Spotify.Players
//{
//    public class ConsolePlayer
//    {
//        private readonly SongService songService = new SongService();
//        private readonly MusicCollectionService musicCollectionService = new MusicCollectionService();
//        private readonly Scanner scanner = new Scanner();

//        public void PlayMusicCollection()
//        {
//            Console.Write("Enter Music Collection Id: ");
//            long musicCollectionId = long.Parse(Console.ReadLine());
//            MusicCollection musicCollection = musicCollectionService.FindById(musicCollectionId);

//            foreach (var song in musicCollection.Songs)
//            {
//                Console.WriteLine($"There's a song playing right now: {song.Name}");
//                PlayMusic(song);
//            }
//        }

//        public void PlayMusic(Song song)
//        {
//            PlayerProcessor(song);
//        }

//        public void PlayMusic()
//        {
//            Console.Write("Enter song Id: ");
//            long songId = long.Parse(Console.ReadLine());
//            Song song = songService.FindSongById(songId);
//            Console.WriteLine(song.GetName());
//            PlayerProcessor(song);
//        }

//        private void PlayerProcessor(Song song)
//        {
//            try
//            {
//                using (var audioFileReader = new AudioFileReader(song.GetFilePath()))
//                using (var outputDevice = new WaveOutEvent())
//                {
//                    outputDevice.Init(audioFileReader);
//                    outputDevice.Play();

//                    Console.WriteLine("Playback has started. Press Enter to stop.");
//                    new Thread(() =>
//                    {
//                        while (outputDevice.PlaybackState == PlaybackState.Playing)
//                        {
//                            // Check for user input to stop playback
//                            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
//                            {
//                                outputDevice.Stop();
//                            }
//                            Thread.Sleep(100);
//                        }
//                    }).Start();

//                    while (outputDevice.PlaybackState == PlaybackState.Playing)
//                    {
//                        Thread.Sleep(500);
//                    }
//                }
//            }
//            catch (FileNotFoundException)
//            {
//                Console.WriteLine("File not found.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Audio playback error.");
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }

//    public class Scanner
//    {
//        public string NextLine() => Console.ReadLine();
//    }
//}

