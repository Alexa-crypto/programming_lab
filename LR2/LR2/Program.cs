using System;

namespace LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;    //для використання "і"
            Console.Write("Введіть кількість смартфонів --> ");
            int n = Convert.ToInt32(Console.ReadLine());
            //int n = 1;
            Phone[] mas = new Phone[n];
            //занесення данних в клас з клавіатури
            for (int i = 0; i < n; i++)
            {
                mas[i] = new Phone();
                Console.Write("Операційна система (Android or IOS) --> ");
                string operatitong_sistem = Console.ReadLine();
                Console.Write("Центральний процессор --> ");
                string cpu = Console.ReadLine();
                Console.Write("Графічний адаптер --> ");
                string gpu = Console.ReadLine();
                Console.Write("Тип корпусу (пластик, метал, скло) --> ");
                string tip_body = Console.ReadLine();
                Console.Write("ROM (Gb) --> ");
                int rom = Convert.ToInt32(Console.ReadLine());
                Console.Write("RAM (Gb) --> ");
                int ram = Convert.ToInt32(Console.ReadLine());
                Console.Write("Наявність камери --> ");
                ConsoleKeyInfo camera = Console.ReadKey();
                Console.WriteLine();
                Console.Write("Наявність біометричних сканерів --> ");
                ConsoleKeyInfo biometrics = Console.ReadKey();
                mas[i].Set_Phone(operatitong_sistem, cpu, gpu, rom, ram, tip_body, camera, biometrics);
                Console.Clear();
            }
            //шапка
            mas[0].Get_Phone_Shapka();
            foreach (Phone i in mas)
                i.Get_Phone();
            Array.Clear(mas, 0, n);
        }
        class Phone
        {
            string operatitong_sistem;
            string cpu;
            string gpu;
            int rom;
            int ram;
            string tip_body;
            bool camera;
            bool biometrics;
            //занесення данних в клас
            public void Set_Phone(string operatitong_sistem, string cpu, string gpu, int rom, int ram, string tip_body, ConsoleKeyInfo camera, ConsoleKeyInfo biometrics)
            {
                this.operatitong_sistem = operatitong_sistem;
                this.cpu = cpu;
                this.gpu = gpu;
                this.rom = rom;
                this.ram = ram;
                this.tip_body = tip_body;
                this.camera = camera.Key == ConsoleKey.Y ? true : false;
                this.biometrics = biometrics.Key == ConsoleKey.Y ? true : false;
            }
            //вивід даних
            public void Get_Phone()
            {
                Console.WriteLine($"| {operatitong_sistem.PadLeft(7)} | {cpu.PadLeft(15)} | {gpu.PadLeft(8)} | {Convert.ToString(rom).PadLeft(2)}/{Convert.ToString(ram).PadLeft(3)} | {tip_body.PadLeft(7)} | " + (camera ? "+" : "-") + "/" + (biometrics ? "+" : "-") + "|");
                Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
            }
            //шапка таблиці
            public void Get_Phone_Shapka()
            {
                Console.WriteLine("┌──────────────────────────────────────────────────────────────┐");
                Console.WriteLine("|    OS   |     Processor   |  Grafic  | ROM/RAM|   Body  | ...|");
                Console.WriteLine("└──────────────────────────────────────────────────────────────┘");
            }
        }
    }
}
