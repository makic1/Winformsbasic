using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineCardAppVersionFour.Entities;

namespace WineCardAppVersionFour.Service
{
    public class ServiceCSv
    {
        private readonly DbContextWineCardApp _context;

        public ServiceCSv(DbContextWineCardApp context)
        {
            _context = context;
        }

        public void ImportCSV(string path)
        {

            // Lösche alle vorhandenen Daten aus den relevanten Tabellen
            //_context.Wines.RemoveRange(_context.Wines);
            //_context.Wineries.RemoveRange(_context.Wineries);
            //_context.WineRegions.RemoveRange(_context.WineRegions);
            //_context.WinesCountries.RemoveRange(_context.WinesCountries);
            //_context.WineTypes.RemoveRange(_context.WineTypes);
            //_context.GrapeVarieties.RemoveRange(_context.GrapeVarieties);
            //_context.Vintages.RemoveRange(_context.Vintages);
            //_context.SaveChanges();

            var lines = File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++) // i= 1 überstringt die kopfzeile im csv
            {
                var cells = lines[i].Split(';');

                WineCountry wineCountry = _context.WinesCountries.FirstOrDefault(c => c.WineCountryName == cells[3]);
                if (wineCountry is null)
                {
                    wineCountry = new WineCountry
                    {
                        WineCountryName = cells[3],
                    };
                    _context.WinesCountries.Add(wineCountry);
                }

                WineRegion wineRegion = _context.WineRegions.FirstOrDefault(wr => wr.RegionName == cells[6]);
                if (wineRegion is null)
                {
                    wineRegion = new WineRegion
                    {
                        RegionName = cells[6],
                        WineCountry = wineCountry
                    };
                    _context.WineRegions.Add(wineRegion);
                }

                Winery winery = _context.Wineries.FirstOrDefault(w => w.WineryName == cells[5]);
                if (winery is null)
                {
                    winery = new Winery
                    {
                        WineryName = cells[5],
                        WineRegion = wineRegion,
                    };
                    _context.Wineries.Add(winery);
                }

                WineType wineType = _context.WineTypes.FirstOrDefault(wt => wt.WineTypeName == cells[2]);
                if (wineType is null)
                {
                    wineType = new WineType
                    {
                        WineTypeName = cells[2],
                    };
                    _context.WineTypes.Add(wineType);
                }

                GrapeVariety grapeVariety = _context.GrapeVarieties.FirstOrDefault(gv => gv.GrapeVarietyName == cells[7]);
                if (grapeVariety is null)
                {
                    grapeVariety = new GrapeVariety
                    {
                        GrapeVarietyName = cells[7],
                    };
                    _context.GrapeVarieties.Add(grapeVariety);
                }

                Vintage vintage = _context.Vintages.FirstOrDefault(v => v.VintageYear == int.Parse(cells[4]));
                if (vintage is null)
                {
                    vintage = new Vintage
                    {
                        VintageYear = int.Parse(cells[4]),
                    };
                    _context.Vintages.Add(vintage);
                }

                Wine existingWine = _context.Wines.FirstOrDefault(w =>
                w.WineName == cells[0] &&
                w.WineType.WineTypeName == cells[2] &&
                w.Winery.WineryName == cells[5]);

                if (existingWine is null)
                {
                    existingWine = new Wine
                    {
                        WineName = cells[0],
                        Price = decimal.Parse(cells[1].Replace("€", "").Trim().Replace(",", "."), CultureInfo.InvariantCulture),
                        WineType = wineType,
                        GrapeVariety = grapeVariety,
                        Winery = winery,
                        Vintage = vintage,
                        //WineCard = null
                    };
                    _context.Wines.Add(existingWine);
                }
                _context.SaveChanges();
            }
        }
    }
}
