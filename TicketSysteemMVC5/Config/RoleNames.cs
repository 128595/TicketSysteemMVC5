namespace TicketSysteemMVC5.Config
{
    public static class RoleNames
    {
        public const string Administrator = "Administrator";

        public const string Medewerker = "Medewerker";

        public const string Klant = "Klant";

        // M.W.D. Buis (04-12-2019): nieuwe rol Technicus toegevoegd.
        public const string Technicus = "Technicus";

        public const string CreeerTickets = "Administrator,Klant";

        public const string BewerkTickets = "Administrator,Medewerker,Klant";

        public const string BewerkApplicaties = "Administrator, Medewerker";
    }
}