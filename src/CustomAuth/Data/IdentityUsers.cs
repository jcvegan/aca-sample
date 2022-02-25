using CustomAuth.Models.Providers;

namespace CustomAuth.Data
{
    public static class IdentityUsers
    {
        public static IEnumerable<IdentityUser> UsersDirectory = new List<IdentityUser>()
        {
            new IdentityUser()
            {
                Alias = "Mister Fantastic",
                FirstName = "Reed",
                LastName = "Richards",
                MemberOf = new string[]
                {
                    "Avengers",
                    "Fantastic Four",
                    "Illuminati",
                    "Future Foundation",
                    "Defenders"
                },
                Username = "rrichards"
            },
            new IdentityUser()
            {
                Alias = "Invisible Woman",
                FirstName = "Susan",
                LastName = "Storm",
                MemberOf = new string[]
                {
                    "Avengers",
                    "Fantastic Four",
                    "Future Foundation",
                    "Lady Liberators"
                },
                Username = "sstorm"
            },
            new IdentityUser()
            {
                Alias = "Human Torch",
                FirstName = "Johnny",
                LastName = "Storm",
                MemberOf = new string[]
                {
                    "Avengers",
                    "Fantastic Four",
                    "Future Foundation"
                },
                Username = "jstorm"
            },
            new IdentityUser()
            {
                Alias = "The Thing",
                FirstName = "Ben",
                LastName = "Grimm",
                MemberOf = new string[]
                {
                    "Avengers",
                    "Fantastic Four",
                    "Future Foundation",
                    "Guardians of the Galaxy",
                    "New Avengers"
                },
                Username = "bgrimm"
            },
            new IdentityUser()
            {
                Alias = "Spider-Man",
                FirstName = "Peter",
                LastName = "Parker",
                MemberOf = new string[]
                {
                    "Avengers",
                    "Future Foundation",
                    "Secret Defenders",
                    "New Avengers"
                },
                Username = "pparker"
            },
            new IdentityUser()
            {
                Alias = "Professor X",
                FirstName = "Charles",
                LastName = "Xavier",
                MemberOf = new string[]
                {
                    "X-Men",
                    "Illuminati"
                },
                Username = "cxavier"
            },
            new IdentityUser()
            {
                Alias = "Iron Man",
                FirstName = "Anthony",
                LastName = "Stark",
                MemberOf = new string[]
                {
                    "Avengers",
                    "Illuminati",
                    "S.H.I.E.L.D."
                },
                Username = "astark"
            },
            new IdentityUser()
            {
                Alias = "Captain America",
                FirstName = "Steve",
                LastName = "Rogers",
                MemberOf = new string[]
                {
                    "Avengers",
                    "Illuminati",
                    "S.H.I.E.L.D."
                },
                Username = "srogers"
            },
            new IdentityUser()
            {
                Alias = "Thor",
                FirstName = "Thor",
                LastName = "Odinson",
                MemberOf = new string[]
                {
                    "Avengers"
                },
                Username = "todinson"
            },
            new IdentityUser()
            {
                Alias = "Professor X",
                FirstName = "Charles",
                LastName = "Xavier",
                MemberOf = new string[]
                {
                    "X-Men",
                    "Illuminati"
                },
                Username = "cxavier"
            },
            new IdentityUser()
            {
                Alias = "Professor X",
                FirstName = "Charles",
                LastName = "Xavier",
                MemberOf = new string[]
                {
                    "X-Men",
                    "Illuminati"
                },
                Username = "cxavier"
            },
            new IdentityUser()
            {
                Alias = "Hulk",
                FirstName = "Bruce",
                LastName = "Banner",
                MemberOf = new string[]
                {
                    "Avengers",
                    "Defenders"
                },
                Username = "bbaner"
            },
            new IdentityUser()
            {
                Alias = "Ant-Man",
                FirstName = "Hank",
                LastName = "Pym",
                MemberOf = new string[]
                {
                    "Avengers",
                    "Defenders"
                },
                Username = "hpym"
            },
        };
    }
}
