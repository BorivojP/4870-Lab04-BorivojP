using Code1st_.Models;

namespace Code1st.Data;

public class SampleData
{
    public static List<Team> GetTeams()
    {
        List<Team> teams = new List<Team>() {
            new Team() {
            TeamName="Lakers",
            City="Los Angeles",
            },
            new Team() {
            TeamName="Golden State Warriors",
            City="Oakland",
            },
            new Team() {
            TeamName="Rockets",
            City="Houston",
            },
            new Team() {
            TeamName="Thunder",
            City="Oklahoma City",
            },
            new Team() {
            TeamName="Pelicans",
            City="New Orleans",
            },
            new Team() {
            TeamName="Raptors",
            City="Toronto",
            },
            new Team() {
            TeamName="Celtics",
            City="Boston",
            },
        };

        return teams;
    }

    public static List<Player> GetPlayers()
    {
        List<Player> players = new List<Player>() {
            new Player {
            PlayerId = 1,
            FirstName = "LeBron",
            LastName = "James",
            TeamName = "Lakers",
            Position = "Shooting Guard"
            },
            new Player {
            PlayerId = 2,
            FirstName = "Kevin",
            LastName = "Durant",
            TeamName = "Golden State Warriors",
            Position = "Power Forward"
            },
            new Player {
            PlayerId = 3,
            FirstName = "Stephen",
            LastName = "Curry",
            TeamName = "Golden State Warriors",
            Position = "Point Guard"
            },
            new Player {
            PlayerId = 4,
            FirstName = "James",
            LastName = "Harden",
            TeamName = "Rockets",
            Position = "Shooting Guard"
            },
        };

        return players;
    }

        public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>() {
            new Province {
            ProvinceCode = "BC",
            ProvinceName = "British Columbia",
            },
            new Province {
            ProvinceCode = "ON",
            ProvinceName = "Ontario",
            },
            new Province {
            ProvinceCode = "QC",
            ProvinceName = "Quebec",
            },
            new Province {
            ProvinceCode = "MB",
            ProvinceName = "Manitoba",
            },
        };

        return provinces;
    }

     public static List<City> GetCities()
    {
        List<City> cities = new List<City>() {
            new City {
            CityId = 1,
            CityName = "Delta",
            Population = 6,
            ProvinceCode = "BC",
            },
            new City {
            CityId = 2,
            CityName = "Ottowa",
            Population = 5,
            ProvinceCode = "ON",
            },
          new City {
            CityId = 3,
            CityName = "Quebec City",
            Population = 321,
            ProvinceCode = "QC",
            },
             new City {
            CityId = 4,
            CityName = "Winnipeg",
            Population = 2152112,
            ProvinceCode = "MB",
            },
        };

        return cities;
    }

}