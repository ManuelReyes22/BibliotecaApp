using System;
using System.Collections.Generic;
using System.IO;
using BibliotecaApp;
using Newtonsoft.Json;

public class Biblioteca
{
    public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
    public List<Libro> Libros { get; set; } = new List<Libro>();
    public List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

    public int ProximoIdUsuario() => Usuarios.Count == 0 ? 1 : Usuarios.Max(u => u.Id) + 1;

    public int ProximoIdLibro() => Libros.Count == 0 ? 1 : Libros.Max(l => l.Id) + 1;

    public int ProximoIdPrestamo() => Prestamos.Count == 0 ? 1 : Prestamos.Max(p => p.Id) + 1;

    public string rutaUsuarios = "usuarios.json";
    public string rutaLibros = "libros.json";
    public string rutaPrestamos = "prestamos.json";

    public Biblioteca()
    {
        CargarDatos();
    }

    public void GuardarDatos()
    {
        File.WriteAllText(rutaUsuarios, JsonConvert.SerializeObject(Usuarios, Formatting.Indented));
        File.WriteAllText(rutaLibros, JsonConvert.SerializeObject(Libros, Formatting.Indented));
        File.WriteAllText(rutaPrestamos, JsonConvert.SerializeObject(Prestamos, Formatting.Indented));
    }

    public void CargarDatos()
    {
        if (File.Exists(rutaUsuarios))
            Usuarios = JsonConvert.DeserializeObject<List<Usuario>>(File.ReadAllText(rutaUsuarios));

        if (File.Exists(rutaLibros))
            Libros = JsonConvert.DeserializeObject<List<Libro>>(File.ReadAllText(rutaLibros));

        if (File.Exists(rutaPrestamos))
            Prestamos = JsonConvert.DeserializeObject<List<Prestamo>>(File.ReadAllText(rutaPrestamos));
    }

    public bool ValidarUsuario(string email, string contrasena)
    {
        return Usuarios.Exists(u => u.Email == email && u.Contrasena == contrasena);
    }
}
