using exercicio1.Entities.Enums;

namespace exercicio1.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public double baseSalary { get; set; }
        public WorkerLevel Level { get; set; }
    }
}