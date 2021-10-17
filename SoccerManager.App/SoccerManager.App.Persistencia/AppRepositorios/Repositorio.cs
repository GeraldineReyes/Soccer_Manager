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
<<<<<<< Updated upstream
        public IEnumerable<Rama> ramas { get; set; }
        public IEnumerable<Modalidad> modalidades { get; set; }
        public IEnumerable<Categoria> categorias { get; set; }
        public IEnumerable<Arbitro> arbitros { get; set; }
        public IEnumerable<Campeonato> campeonatos { get; set; }
        public IEnumerable<Equipo_Jugador> equipo_Jugadores { get; set; }
        public IEnumerable<Equipo_Partido> equipo_Partidos { get; set; }
        public IEnumerable<Equipo> equipos { get; set; }
        public IEnumerable<Jugador> jugadores { get; set; }
        public IEnumerable<Partido_Jugador> partido_Jugadores { get; set; }
=======
        public IEnumerable<Cancha> canchas { get; set; }
>>>>>>> Stashed changes

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
        //===============================================================================================
        //CRUD Cancha
        Cancha IRepositorios.AddCancha(Cancha cancha)
        {
            try
            {
                var CanchaAdicionado = _appContext.Canchas.Add(cancha);  //INSERT en la BD
                _appContext.SaveChanges();
                return CanchaAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Cancha> IRepositorios.GetAllCanchas(string? Nombre)
        {
            if (Nombre != null)
            {
                canchas = _appContext.Canchas.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                canchas = _appContext.Canchas;  //select * from tutor
            return canchas;
        }

        Cancha IRepositorios.GetCancha(int? IdCancha)
        {
            return _appContext.Canchas.FirstOrDefault(p => p.Id == IdCancha);
        }

        Cancha IRepositorios.UpdateCancha(Cancha cancha)
        {
            var CanchaEncontrado = _appContext.Canchas.FirstOrDefault(p => p.Id == cancha.Id);
            if (CanchaEncontrado != null)
            {

                CanchaEncontrado.Nombre = cancha.Nombre;
                CanchaEncontrado.Cantidad_Canchas = cancha.Cantidad_Canchas;
                CanchaEncontrado.Direccion = cancha.Direccion;
                CanchaEncontrado.Telefono = cancha.Telefono;
                CanchaEncontrado.Email = cancha.Email;
                CanchaEncontrado.Contacto = cancha.Contacto;
                CanchaEncontrado.Campo = cancha.Campo;


                _appContext.SaveChanges();
            }
            return CanchaEncontrado;
        }

        void IRepositorios.DeleteCancha(int IdCancha)
        {
            var CanchaEncontrado = _appContext.Canchas.FirstOrDefault(p => p.Id == IdCancha);
            if (CanchaEncontrado == null)
                return;
            _appContext.Canchas.Remove(CanchaEncontrado);
            _appContext.SaveChanges();
        }

//===============================================================================================
        //CRUD Rama
        Rama IRepositorios.AddRama(Rama rama)
        {
            try
            {
                var RamaAdicionado = _appContext.Ramas.Add(rama);  //INSERT en la BD
                _appContext.SaveChanges();
                return RamaAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Rama> IRepositorios.GetAllRamas(string? Nombre)
        {
            if (Nombre != null)
            {
                ramas = _appContext.Ramas.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                ramas = _appContext.Ramas;  //select * from tutor
            return ramas;
        }

        Rama IRepositorios.GetRama(int? IdRama)
        {
            return _appContext.Ramas.FirstOrDefault(p => p.Id == IdRama);
        }

        Rama IRepositorios.UpdateRama(Rama rama)
        {
            var RamaEncontrado = _appContext.Ramas.FirstOrDefault(p => p.Id == rama.Id);
            if (RamaEncontrado != null)
            {

                RamaEncontrado.Nombre = rama.Nombre;



                _appContext.SaveChanges();
            }
            return RamaEncontrado;
        }

        void IRepositorios.DeleteRama(int IdRama)
        {
            var RamaEncontrado = _appContext.Ramas.FirstOrDefault(p => p.Id == IdRama);
            if (RamaEncontrado == null)
                return;
            _appContext.Ramas.Remove(RamaEncontrado);
            _appContext.SaveChanges();
        }
//===============================================================================================
        //CRUD Modalidad
        Modalidad IRepositorios.AddModalidad(Modalidad modalidad)
        {
            try
            {
                var ModalidadAdicionado = _appContext.Modalidades.Add(modalidad);  //INSERT en la BD
                _appContext.SaveChanges();
                return ModalidadAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Modalidad> IRepositorios.GetAllModalidades(string? Nombre)
        {
            if (Nombre != null)
            {
                modalidades = _appContext.Modalidades.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                modalidades = _appContext.Modalidades;  //select * from tutor
            return modalidades;
        }

        Modalidad IRepositorios.GetModalidad(int? IdModalidad)
        {
            return _appContext.Modalidades.FirstOrDefault(p => p.Id == IdModalidad);
        }

        Modalidad IRepositorios.UpdateModalidad(Modalidad modalidad)
        {
            var ModalidadEncontrado = _appContext.Modalidades.FirstOrDefault(p => p.Id == modalidad.Id);
            if (ModalidadEncontrado != null)
            {

                ModalidadEncontrado.Nombre = modalidad.Nombre;



                _appContext.SaveChanges();
            }
            return ModalidadEncontrado;
        }

        void IRepositorios.DeleteModalidad(int IdModalidad)
        {
            var ModalidadEncontrado = _appContext.Modalidades.FirstOrDefault(p => p.Id == IdModalidad);
            if (ModalidadEncontrado == null)
                return;
            _appContext.Modalidades.Remove(ModalidadEncontrado);
            _appContext.SaveChanges();
        }
//===============================================================================================
        //CRUD Categoria
        Categoria IRepositorios.AddCategoria(Categoria categoria)
        {
            try
            {
                var CategoriaAdicionado = _appContext.Categorias.Add(categoria);  //INSERT en la BD
                _appContext.SaveChanges();
                return CategoriaAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Categoria> IRepositorios.GetAllCategorias(string? Nombre)
        {
            if (Nombre != null)
            {
                categorias = _appContext.Categorias.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                categorias = _appContext.Categorias;  //select * from tutor
            return categorias;
        }

        Categoria IRepositorios.GetCategoria(int? IdCategoria)
        {
            return _appContext.Categorias.FirstOrDefault(p => p.Id == IdCategoria);
        }

        Categoria IRepositorios.UpdateCategoria(Categoria categoria)
        {
            var CategoriaEncontrado = _appContext.Categorias.FirstOrDefault(p => p.Id == categoria.Id);
            if (CategoriaEncontrado != null)
            {

                CategoriaEncontrado.Nombre = categoria.Nombre;



                _appContext.SaveChanges();
            }
            return CategoriaEncontrado;
        }

        void IRepositorios.DeleteCategoria(int IdCategoria)
        {
            var CategoriaEncontrado = _appContext.Categorias.FirstOrDefault(p => p.Id == IdCategoria);
            if (CategoriaEncontrado == null)
                return;
            _appContext.Categorias.Remove(CategoriaEncontrado);
            _appContext.SaveChanges();
        }

//===============================================================================================
        //CRUD Arbitro
        Arbitro IRepositorios.AddArbitro(Arbitro arbitro)
        {
            try
            {
                var ArbitroAdicionado = _appContext.Arbitros.Add(arbitro);  //INSERT en la BD
                _appContext.SaveChanges();
                return ArbitroAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

//        IEnumerable<Arbitro> IRepositorios.GetAllArbitros(string? Nombre)
 //       {
//            if (Nombre != null)
 //           {
 //               arbitros = _appContext.Arbitros.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
 //           }
 //           else
 //               arbitros = _appContext.Arbitros;  //select * from tutor
 //           return arbitros;
 //       }

        Arbitro IRepositorios.GetArbitro(int? IdArbitro)
        {
            return _appContext.Arbitros.FirstOrDefault(p => p.Id == IdArbitro);
        }

        Arbitro IRepositorios.UpdateArbitro(Arbitro arbitro)
        {
            var ArbitroEncontrado = _appContext.Arbitros.FirstOrDefault(p => p.Id == arbitro.Id);
            if (ArbitroEncontrado != null)
            {

                ArbitroEncontrado.Certificado = arbitro.Certificado;



                _appContext.SaveChanges();
            }
            return ArbitroEncontrado;
        }

        void IRepositorios.DeleteArbitro(int IdArbitro)
        {
            var ArbitroEncontrado = _appContext.Arbitros.FirstOrDefault(p => p.Id == IdArbitro);
            if (ArbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(ArbitroEncontrado);
            _appContext.SaveChanges();
        }
//===============================================================================================
        //CRUD Campeonato
        Campeonato IRepositorios.AddCampeonato(Campeonato campeonato)
        {
            try
            {
                var CampeonatoAdicionado = _appContext.Campeonatos.Add(campeonato);  //INSERT en la BD
                _appContext.SaveChanges();
                return CampeonatoAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Campeonato> IRepositorios.GetAllCampeonatos(string? Nombre)
        {
            if (Nombre != null)
            {
                campeonatos = _appContext.Campeonatos.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                campeonatos = _appContext.Campeonatos;  //select * from tutor
            return campeonatos;
        }

        Campeonato IRepositorios.GetCampeonato(int? IdCampeonato)
        {
            return _appContext.Campeonatos.FirstOrDefault(p => p.Id == IdCampeonato);
        }

        Campeonato IRepositorios.UpdateCampeonato(Campeonato campeonato)
        {
            var CampeonatoEncontrado = _appContext.Campeonatos.FirstOrDefault(p => p.Id == campeonato.Id);
            if (CampeonatoEncontrado != null)
            {

                CampeonatoEncontrado.Nombre = campeonato.Nombre;
                CampeonatoEncontrado.Fecha_Inicial = campeonato.Fecha_Inicial;
                CampeonatoEncontrado.Fecha_Fin = campeonato.Fecha_Fin;
                CampeonatoEncontrado.Reglamento = campeonato.Reglamento;
                CampeonatoEncontrado.Numero_Eliminatorias = campeonato.Numero_Eliminatorias;
                CampeonatoEncontrado.Numero_Equipos_Premiados = campeonato.Numero_Equipos_Premiados;
                CampeonatoEncontrado.Estado = campeonato.Estado;
                CampeonatoEncontrado.Numero_Equipos = campeonato.Numero_Equipos;



                _appContext.SaveChanges();
            }
            return CampeonatoEncontrado;
        }

        void IRepositorios.DeleteCampeonato(int IdCampeonato)
        {
            var CampeonatoEncontrado = _appContext.Campeonatos.FirstOrDefault(p => p.Id == IdCampeonato);
            if (CampeonatoEncontrado == null)
                return;
            _appContext.Campeonatos.Remove(CampeonatoEncontrado);
            _appContext.SaveChanges();
        }

//===============================================================================================
        //CRUD Equipo_Jugador
        Equipo_Jugador IRepositorios.AddEquipo_Jugador(Equipo_Jugador equipo_Jugador)
        {
            try
            {
                var Equipo_JugadorAdicionado = _appContext.Equipo_Jugadores.Add(equipo_Jugador);  //INSERT en la BD
                _appContext.SaveChanges();
                return Equipo_JugadorAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Equipo_Jugador> IRepositorios.GetAllEquipo_Jugadores(string? Dorsal)
        {
            if (Dorsal != null)
            {
                equipo_Jugadores = _appContext.Equipo_Jugadores.Where(p => p.Dorsal.Contains(Dorsal)); //like sobre la tabla
            }
            else
                equipo_Jugadores = _appContext.Equipo_Jugadores;  //select * from tutor
            return equipo_Jugadores;
        }

        Equipo_Jugador IRepositorios.GetEquipo_Jugador(int? IdEquipo_Jugador)
        {
            return _appContext.Equipo_Jugadores.FirstOrDefault(p => p.Id == IdEquipo_Jugador);
        }

        Equipo_Jugador IRepositorios.UpdateEquipo_Jugador(Equipo_Jugador equipo_Jugador)
        {
            var Equipo_JugadorEncontrado = _appContext.Equipo_Jugadores.FirstOrDefault(p => p.Id == equipo_Jugador.Id);
            if (Equipo_JugadorEncontrado != null)
            {

                Equipo_JugadorEncontrado.Dorsal = equipo_Jugador.Dorsal;
                Equipo_JugadorEncontrado.Posicion = equipo_Jugador.Posicion;
                Equipo_JugadorEncontrado.Abreviatura_Posicion = equipo_Jugador.Abreviatura_Posicion;



                _appContext.SaveChanges();
            }
            return Equipo_JugadorEncontrado;
        }

        void IRepositorios.DeleteEquipo_Jugador(int IdEquipo_Jugador)
        {
            var Equipo_JugadorEncontrado = _appContext.Equipo_Jugadores.FirstOrDefault(p => p.Id == IdEquipo_Jugador);
            if (Equipo_JugadorEncontrado == null)
                return;
            _appContext.Equipo_Jugadores.Remove(Equipo_JugadorEncontrado);
            _appContext.SaveChanges();
        }
//===============================================================================================
        //CRUD Equipo_Partido
        Equipo_Partido IRepositorios.AddEquipo_Partido(Equipo_Partido equipo_Partido)
        {
            try
            {
                var Equipo_PartidoAdicionado = _appContext.Equipo_Partidos.Add(equipo_Partido);  //INSERT en la BD
                _appContext.SaveChanges();
                return Equipo_PartidoAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Equipo_Partido> IRepositorios.GetAllEquipo_Partidos(string? Equipo_Local)
        {
            if (Equipo_Local != null)
            {
                equipo_Partidos = _appContext.Equipo_Partidos.Where(p => p.Equipo_Local.Contains(Equipo_Local)); //like sobre la tabla
            }
            else
                equipo_Partidos = _appContext.Equipo_Partidos;  //select * from tutor
            return equipo_Partidos;
        }

        Equipo_Partido IRepositorios.GetEquipo_Partido(int? IdEquipo_Partido)
        {
            return _appContext.Equipo_Partidos.FirstOrDefault(p => p.Id == IdEquipo_Partido);
        }

        Equipo_Partido IRepositorios.UpdateEquipo_Partido(Equipo_Partido equipo_Partido)
        {
            var Equipo_PartidoEncontrado = _appContext.Equipo_Partidos.FirstOrDefault(p => p.Id == equipo_Partido.Id);
            if (Equipo_PartidoEncontrado != null)
            {

                Equipo_PartidoEncontrado.Equipo_Local = equipo_Partido.Equipo_Local;
                Equipo_PartidoEncontrado.Equipo_Visitante = equipo_Partido.Equipo_Visitante;
                Equipo_PartidoEncontrado.Fecha = equipo_Partido.Fecha;
                Equipo_PartidoEncontrado.Hora = equipo_Partido.Hora;



                _appContext.SaveChanges();
            }
            return Equipo_PartidoEncontrado;
        }

        void IRepositorios.DeleteEquipo_Partido(int IdEquipo_Partido)
        {
            var Equipo_PartidoEncontrado = _appContext.Equipo_Partidos.FirstOrDefault(p => p.Id == IdEquipo_Partido);
            if (Equipo_PartidoEncontrado == null)
                return;
            _appContext.Equipo_Partidos.Remove(Equipo_PartidoEncontrado);
            _appContext.SaveChanges();
        }
//===============================================================================================
        //CRUD Equipo
        Equipo IRepositorios.AddEquipo(Equipo equipo)
        {
            try
            {
                var EquipoAdicionado = _appContext.Equipos.Add(equipo);  //INSERT en la BD
                _appContext.SaveChanges();
                return EquipoAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Equipo> IRepositorios.GetAllEquipos(string? Nombre)
        {
            if (Nombre != null)
            {
                equipos = _appContext.Equipos.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
            }
            else
                equipos = _appContext.Equipos;  //select * from tutor
            return equipos;
        }

        Equipo IRepositorios.GetEquipo(int? IdEquipo)
        {
            return _appContext.Equipos.FirstOrDefault(p => p.Id == IdEquipo);
        }

        Equipo IRepositorios.UpdateEquipo(Equipo equipo)
        {
            var EquipoEncontrado = _appContext.Equipos.FirstOrDefault(p => p.Id == equipo.Id);
            if (EquipoEncontrado != null)
            {

                EquipoEncontrado.Nombre = equipo.Nombre;
                EquipoEncontrado.Numero_Jugadores = equipo.Numero_Jugadores;
                EquipoEncontrado.Estado = equipo.Estado;
                EquipoEncontrado.Color_Uniforme_Local = equipo.Color_Uniforme_Local;
                EquipoEncontrado.Color_Uniforme_Visitante = equipo.Color_Uniforme_Visitante;
                EquipoEncontrado.Contacto = equipo.Contacto;
                EquipoEncontrado.Telefono = equipo.Telefono;
                EquipoEncontrado.Email = equipo.Email;



                _appContext.SaveChanges();
            }
            return EquipoEncontrado;
        }

        void IRepositorios.DeleteEquipo(int IdEquipo)
        {
            var EquipoEncontrado = _appContext.Equipos.FirstOrDefault(p => p.Id == IdEquipo);
            if (EquipoEncontrado == null)
                return;
            _appContext.Equipos.Remove(EquipoEncontrado);
            _appContext.SaveChanges();
        }

//=============================================================================================

    //CRUD Jugador
        Jugador IRepositorios.AddJugador(Jugador jugador)
        {
            try
            {
                var JugadorAdicionado = _appContext.Jugadores.Add(jugador);  //INSERT en la BD
                _appContext.SaveChanges();
                return JugadorAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

//          IEnumerable<Jugador> IRepositorios.GetAllJugadores(string? Nombre)
//          {
//              if (Nombre != null)
//              {
//                  jugadores = _appContext.Jugadores.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
//              }
//              else
//                  jugadores = _appContext.Jugadores;  //select * from tutor
//              return jugadores;
//          }

       Jugador IRepositorios.GetJugador(int? IdJugador)
        {
            return _appContext.Jugadores.FirstOrDefault(p => p.Id == IdJugador);
        }

        Jugador IRepositorios.UpdateJugador(Jugador jugador)
        {
            var JugadorEncontrado = _appContext.Jugadores.FirstOrDefault(p => p.Id == jugador.Id);
            if (JugadorEncontrado != null)
            {

                JugadorEncontrado.Altura = jugador.Altura;
                JugadorEncontrado.Peso = jugador.Peso;
               

                _appContext.SaveChanges();
            }
            return JugadorEncontrado;
        }

        void IRepositorios.DeleteJugador(int IdJugador)
        {
            var JugadorEncontrado = _appContext.Jugadores.FirstOrDefault(p => p.Id == IdJugador);
            if (JugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(JugadorEncontrado);
            _appContext.SaveChanges();
        }

        //========================================================================================
//CRUD Partido_Jugador
        Partido_Jugador IRepositorios.AddPartido_Jugador(Partido_Jugador partido_Jugador)
        {
            try
            {
                var Partido_JugadorAdicionado = _appContext.Partido_Jugadores.Add(partido_Jugador);  //INSERT en la BD
                _appContext.SaveChanges();
                return Partido_JugadorAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

//        IEnumerable<Partido_Jugador> IRepositorios.GetAllPartido_Jugadores(string? Nombre)
//          {
//              if (Nombre != null)
//              {
//                  partido_Jugadores = _appContext.Partido_Jugadores.Where(p => p.Nombre.Contains(Nombre)); //like sobre la tabla
//              }
//              else
//                  partido_Jugadores = _appContext.Partido_Jugadores;  //select * from tutor
//              return partido_Jugadores;
//          }

        Partido_Jugador IRepositorios.GetPartido_Jugador(int? IdPartido_Jugador)
        {
            return _appContext.Partido_Jugadores.FirstOrDefault(p => p.Id == IdPartido_Jugador);
        }

        Partido_Jugador IRepositorios.UpdatePartido_Jugador(Partido_Jugador partido_Jugador)
        {
            var Partido_JugadorEncontrado = _appContext.Partido_Jugadores.FirstOrDefault(p => p.Id == partido_Jugador.Id);
            if (Partido_JugadorEncontrado != null)
            {

                Partido_JugadorEncontrado.Gol = partido_Jugador.Gol;
                Partido_JugadorEncontrado.Falta = partido_Jugador.Falta;
                Partido_JugadorEncontrado.Tarjeta_Roja = partido_Jugador.Tarjeta_Roja;
                Partido_JugadorEncontrado.Tarjeta_Amarilla = partido_Jugador.Tarjeta_Amarilla;
                Partido_JugadorEncontrado.Tarjeta_Azul = partido_Jugador.Tarjeta_Azul;
                Partido_JugadorEncontrado.Autogol = partido_Jugador.Autogol;
                Partido_JugadorEncontrado.Minuto = partido_Jugador.Minuto;



                _appContext.SaveChanges();
            }
            return Partido_JugadorEncontrado;
        }

        void IRepositorios.DeletePartido_Jugador(int IdPartido_Jugador)
        {
            var Partido_JugadorEncontrado = _appContext.Partido_Jugadores.FirstOrDefault(p => p.Id == IdPartido_Jugador);
            if (Partido_JugadorEncontrado == null)
                return;
            _appContext.Partido_Jugadores.Remove(Partido_JugadorEncontrado);
            _appContext.SaveChanges();
        }

//===============================================================================================
    }
}

