# MP3 Player

## Description
Develop a console application that allows users to manage a collection of songs, albums, and artists. The application includes classes for representing songs, albums, artists, and genres, as well as interfaces for playing and managing the collection. Users can add, delete, and play songs, as well as view information about songs, albums, and artists.

## Functionality

### Manage Artists
- Add artists
- Update artists
- Show artists
- Delete artists

### Manage Songs
- Add songs
- Update songs
- Show songs
- Delete songs

### Manage Albums
- Add albums
- Update albums
- Show albums
- Delete albums

### Manage Radio
- Add radio
- Update radio
- Show radio
- Delete radio

### Playback
- Play songs
- Play albums
- Play radio


## Technologies

The following technologies are used in the project:

- **C#** - the main programming language.
- **Entity Framework** - ORM (Object-Relational Mapping) for working with the database.
- **PostgreSQL** - relational database for storing data about songs, albums, and artists.
- **NUnit** - testing framework.
- **NAudio** - library for audio handling.
- **S.O.L.I.D.** - principles for creating maintainable and scalable code.
- **Design Patterns** - using design patterns to improve architecture.

## Installation and Startup

1. Ensure you have the following components installed:
   - .NET SDK (e.g., .NET 6 or 7).
   - PostgreSQL.
   - NuGet packages: `Npgsql.EntityFrameworkCore.PostgreSQL`, `NAudio`, `NUnit`.

2. Create a database named `SpotifyCSharp` in PostgreSQL.

3. Clone or create the project:

   ```bash
   git clone https://github.com/your-repo/Spotify.git
   cd Spotify
