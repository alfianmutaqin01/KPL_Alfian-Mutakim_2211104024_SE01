﻿using System;
using System.IO;
using System.Text.Json;

class DataMahasiswa2211104024
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public static void ReadJSON()
    {
        string filePath = "TP_07_1_2211104024.json";  // Sesuaikan jika ada folder "Data/"
        string jsonString = File.ReadAllText(filePath);

        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
        Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} " +
            $"dengan NIM {mhs.nim} dari Fakultas {mhs.fakultas}");
    }
}
