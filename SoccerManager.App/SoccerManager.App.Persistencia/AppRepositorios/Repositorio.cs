using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using SoccerManager.App.Dominio;

namespace SoccerManager.App.Persistencia
{
    public class Repositorios : IRepositorios
    {
        private readonly AppContext _appContext;
        public IEnumerable<Persona> personas { get; set; }
        public IEnumerable<Tipo_Documento> tipos_documentos { get; set; }

        public IEnumerable<Campo> campos { get; set; }
        public IEnumerable<Genero> generos { get; set; }
        public IEnumerable<Ciudad> ciudades { get; set; }
        public IEnumerable<Perfil> perfiles { get; set; }

        public Repositorios(AppContext appContext)
        {
            _appContext = appContext;
        }
        //===============================================================================================
        //CRUD PERSONA
        Persona IRepositorios.AddPersona(Persona persona)
        {
            try
            {
                var PersonaAdicionado = _appContext.Personas.Add(persona);  //INSERT en la BD
                _appContext.SaveChanges();
                return PersonaAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Persona> IRepositorios.GetAllPersonas(string? Nombre)
        {
            if (Nombre != null)
            {
                personas = _appContext.Personas.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                personas = _appContext.Personas;  //select * from formador
            return personas;
        }

        Persona IRepositorios.GetPersona(int? IdPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == IdPersona);
        }

        Persona IRepositorios.UpdatePersona(Persona persona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if (PersonaEncontrado != null)
            {

                PersonaEncontrado.Nombre = persona.Nombre;
                PersonaEncontrado.Apellido = persona.Apellido;
                PersonaEncontrado.Correo = persona.Correo;
                PersonaEncontrado.Num_Documento = persona.Num_Documento;
                PersonaEncontrado.Telefono = persona.Telefono;
                PersonaEncontrado.Fecha_Nacimiento = persona.Fecha_Nacimiento;
                PersonaEncontrado.Tipo_Documento = persona.Tipo_Documento;
                PersonaEncontrado.Genero = persona.Genero;
                PersonaEncontrado.Ciudad = persona.Ciudad;
                PersonaEncontrado.Perfil = persona.Perfil;


                _appContext.SaveChanges();
            }
            return PersonaEncontrado;
        }

        void IRepositorios.DeletePersona(int IdPersona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == IdPersona);
            if (PersonaEncontrado == null)
                return;
            _appContext.Personas.Remove(PersonaEncontrado);
            _appContext.SaveChanges();
        }
        //===============================================================================================
        //CRUD CAMPO
        Campo IRepositorios.AddCampo(Campo campo)
        {
            try
            {
                var CampoAdicionado = _appContext.Campos.Add(campo);  //INSERT en la BD
                _appContext.SaveChanges();
                return CampoAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Campo> IRepositorios.GetAllCampos(string? Nombre)
        {
            if (Nombre != null)
            {
                campos = _appContext.Campos.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                campos = _appContext.Campos;  //select * from tutor
            return campos;
        }

        Campo IRepositorios.GetCampo(int? IdCampo)
        {
            return _appContext.Campos.FirstOrDefault(p => p.Id == IdCampo);
        }

        Campo IRepositorios.UpdateCampo(Campo campo)
        {
            var CampoEncontrado = _appContext.Campos.FirstOrDefault(p => p.Id == campo.Id);
            if (CampoEncontrado != null)
            {

                CampoEncontrado.Nombre = campo.Nombre;
                CampoEncontrado.Fecha_Horario_Inicial = campo.Fecha_Horario_Inicial;
                CampoEncontrado.Fecha_Horario_Final = campo.Fecha_Horario_Final;

                _appContext.SaveChanges();
            }
            return CampoEncontrado;
        }

        void IRepositorios.DeleteCampo(int IdCampo)
        {
            var CampoEncontrado = _appContext.Campos.FirstOrDefault(p => p.Id == IdCampo);
            if (CampoEncontrado == null)
                return;
            _appContext.Campos.Remove(CampoEncontrado);
            _appContext.SaveChanges();
        }
        //===============================================================================================
        //CRUD TIPO DE DOCUMENTO
        Tipo_Documento IRepositorios.AddTipo_Documento(Tipo_Documento tipo_documento)
        {
            try
            {
                var Tipo_DocumentoAdicionado = _appContext.Tipos_Documentos.Add(tipo_documento);  //INSERT en la BD
                _appContext.SaveChanges();
                return Tipo_DocumentoAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Tipo_Documento> IRepositorios.GetAllTipos_Documentos(string? Nombre)
        {
            if (Nombre != null)
            {
                tipos_documentos = _appContext.Tipos_Documentos.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                tipos_documentos = _appContext.Tipos_Documentos;  //select * from equipo
            return tipos_documentos;
        }

        Tipo_Documento IRepositorios.GetTipo_Documento(int? IdTipo_Documento)
        {
            return _appContext.Tipos_Documentos.FirstOrDefault(p => p.Id == IdTipo_Documento);
        }

        Tipo_Documento IRepositorios.UpdateTipo_Documento(Tipo_Documento tipo_documento)
        {
            var Tipo_DocumentoEncontrado = _appContext.Tipos_Documentos.FirstOrDefault(p => p.Id == tipo_documento.Id);
            if (Tipo_DocumentoEncontrado != null)
            {

                Tipo_DocumentoEncontrado.Nombre = tipo_documento.Nombre;
                Tipo_DocumentoEncontrado.Abreviatura = tipo_documento.Abreviatura;


                _appContext.SaveChanges();
            }
            return Tipo_DocumentoEncontrado;
        }

        void IRepositorios.DeleteTipo_Documento(int IdTipo_Documento)
        {
            var Tipo_DocumentoEncontrado = _appContext.Tipos_Documentos.FirstOrDefault(p => p.Id == IdTipo_Documento);
            if (Tipo_DocumentoEncontrado == null)
                return;
            _appContext.Tipos_Documentos.Remove(Tipo_DocumentoEncontrado);
            _appContext.SaveChanges();
        }
        //===============================================================================================
        //CRUD GENERO
        Genero IRepositorios.AddGenero(Genero genero)
        {
            try
            {
                var GeneroAdicionado = _appContext.Generos.Add(genero);  //INSERT en la BD
                _appContext.SaveChanges();
                return GeneroAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Genero> IRepositorios.GetAllGeneros(string? Nombre)
        {
            if (Nombre != null)
            {
                generos = _appContext.Generos.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                generos = _appContext.Generos;  //select * from tutor
            return generos;
        }

        Genero IRepositorios.GetGenero(int? IdGenero)
        {
            return _appContext.Generos.FirstOrDefault(p => p.Id == IdGenero);
        }

        Genero IRepositorios.UpdateGenero(Genero genero)
        {
            var GeneroEncontrado = _appContext.Generos.FirstOrDefault(p => p.Id == genero.Id);
            if (GeneroEncontrado != null)
            {

                GeneroEncontrado.Nombre = genero.Nombre;
                GeneroEncontrado.Abreviatura = genero.Abreviatura;


                _appContext.SaveChanges();
            }
            return GeneroEncontrado;
        }

        void IRepositorios.DeleteGenero(int IdGenero)
        {
            var GeneroEncontrado = _appContext.Generos.FirstOrDefault(p => p.Id == IdGenero);
            if (GeneroEncontrado == null)
                return;
            _appContext.Generos.Remove(GeneroEncontrado);
            _appContext.SaveChanges();
        }
        //===============================================================================================
        //CRUD Ciudad
        Ciudad IRepositorios.AddCiudad(Ciudad ciudad)
        {
            try
            {
                var CiudadAdicionado = _appContext.Ciudades.Add(ciudad);  //INSERT en la BD
                _appContext.SaveChanges();
                return CiudadAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Ciudad> IRepositorios.GetAllCiudades(string? Nombre)
        {
            if (Nombre != null)
            {
                ciudades = _appContext.Ciudades.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                ciudades = _appContext.Ciudades;  //select * from tutor
            return ciudades;
        }

        Ciudad IRepositorios.GetCiudad(int? IdCiudad)
        {
            return _appContext.Ciudades.FirstOrDefault(p => p.Id == IdCiudad);
        }

        Ciudad IRepositorios.UpdateCiudad(Ciudad ciudad)
        {
            var CiudadEncontrado = _appContext.Ciudades.FirstOrDefault(p => p.Id == ciudad.Id);
            if (CiudadEncontrado != null)
            {

                CiudadEncontrado.Nombre = ciudad.Nombre;



                _appContext.SaveChanges();
            }
            return CiudadEncontrado;
        }

        void IRepositorios.DeleteCiudad(int IdCiudad)
        {
            var CiudadEncontrado = _appContext.Ciudades.FirstOrDefault(p => p.Id == IdCiudad);
            if (CiudadEncontrado == null)
                return;
            _appContext.Ciudades.Remove(CiudadEncontrado);
            _appContext.SaveChanges();
        }
        //===============================================================================================
        //CRUD Perfil
        Perfil IRepositorios.AddPerfil(Perfil perfil)
        {
            try
            {
                var PerfilAdicionado = _appContext.Perfiles.Add(perfil);  //INSERT en la BD
                _appContext.SaveChanges();
                return PerfilAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Perfil> IRepositorios.GetAllPerfiles(string? Nombre)
        {
            if (Nombre != null)
            {
                perfiles = _appContext.Perfiles.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                perfiles = _appContext.Perfiles;  //select * from tutor
            return perfiles;
        }

        Perfil IRepositorios.GetPerfil(int? IdPerfil)
        {
            return _appContext.Perfiles.FirstOrDefault(p => p.Id == IdPerfil);
        }

        Perfil IRepositorios.UpdatePerfil(Perfil perfil)
        {
            var PerfilEncontrado = _appContext.Perfiles.FirstOrDefault(p => p.Id == perfil.Id);
            if (PerfilEncontrado != null)
            {

                PerfilEncontrado.Nombre = perfil.Nombre;



                _appContext.SaveChanges();
            }
            return PerfilEncontrado;
        }

        void IRepositorios.DeletePerfil(int IdPerfil)
        {
            var PerfilEncontrado = _appContext.Perfiles.FirstOrDefault(p => p.Id == IdPerfil);
            if (PerfilEncontrado == null)
                return;
            _appContext.Perfiles.Remove(PerfilEncontrado);
            _appContext.SaveChanges();
        }


    }
}

