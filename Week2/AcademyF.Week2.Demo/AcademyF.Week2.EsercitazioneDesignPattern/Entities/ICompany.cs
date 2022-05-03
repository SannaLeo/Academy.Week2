namespace AcademyF.Week2.EsercitazioneDesignPattern.Entities
{
    public interface ICompany
    {
        public string Name { get; set; }
        public static List<Employee> Employees { get; set; }
    }
}