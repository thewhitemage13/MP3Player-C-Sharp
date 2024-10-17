using Spotify.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Services.Interfaces
{
    /// <summary>
    /// Provides operations for managing <see cref="Radio"/> entities.
    /// </summary>
    public interface IRadioService
    {
        Radio GetRadioById(long id);
        List<Radio> GetAllRadios();
        void AddRadio(Radio radio);
        void UpdateRadio(Radio radio);
        void DeleteRadio(long id);
    }
}
