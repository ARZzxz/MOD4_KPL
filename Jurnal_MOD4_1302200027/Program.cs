namespace Jurnal_MOD4_1302200027
{
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T databaru)
        {
            storedData.Add(databaru);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi : " + storedData[i] + " yang disimpan pada waktu UTC : " + inputDates[i] + " AM");
            }
        }
    }