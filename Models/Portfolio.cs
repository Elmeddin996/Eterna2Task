namespace EternaAddedPortofilo.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Portfolioİmageİd { get; set; }
        public int PortfolioCategorieİd { get; set; }

        public PortfolioCategories Categories { get; set; }
        public Portfolioİmages Portfolioİmages { get; set; }
    }
}
