using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    public class Phone
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
        public void Set_Phone(string operatitong_sistem, string cpu, string gpu, int rom, int ram, string tip_body, bool camera, bool biometrics)
        {
            this.operatitong_sistem = operatitong_sistem;
            this.cpu = cpu;
            this.gpu = gpu;
            this.rom = rom;
            this.ram = ram;
            this.tip_body = tip_body;
            this.camera = camera;
            this.biometrics = biometrics;
        }
        //вивід даних
        public void Get_Phone(System.Windows.Forms.TextBox tb)
        {
            tb.Text += $"\n\r\n\r| {operatitong_sistem.PadLeft(7)} | {cpu.PadLeft(15)} | {gpu.PadLeft(9)} | {Convert.ToString(rom).PadLeft(3)}/{Convert.ToString(ram).PadLeft(2)} | {tip_body.PadLeft(7)} |              " + (camera ? "+" : "-") + "/" + (biometrics ? "+" : "-") + "|";
            //tb.Text += "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
        }
        //шапка таблиці
        //public void Get_Phone_Shapka()
        //{
        //    Console.WriteLine("┌──────────────────────────────────────────────────────────────┐");
        //    Console.WriteLine("|    OS   |     Processor   |  Grafic  | ROM/RAM|   Body  | ...|");
        //    Console.WriteLine("└──────────────────────────────────────────────────────────────┘");
        //}
    }
}
