using System.Collections.Generic;
using System.Linq;
using SoccerManager.App.Dominio;


namespace SoccerManager.App.Persistencia
{
    public interface IRepositorios
    {
        //CRUD PERSONA
        IEnumerable<Persona> GetAllPersonas(string? Nombre);

        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);

        void DeletePersona(int IdPersona);
        
        Persona GetPersona(int? IdPersona);
        //========================================================================================
        //CRUD CAMPOS

        IEnumerable<Campo> GetAllCampos(string? Nombre);

        Campo AddCampo(Campo campo);

        Campo UpdateCampo(Campo campo);

        void DeleteCampo(int IdCampo);

        Campo GetCampo(int? IdCampo);
        //========================================================================================
        //========================================================================================
        //CRUD TIPO DOCUMENTO

        IEnumerable<Tipo_Documento> GetAllTipos_Documentos(string? Nombre);

        Tipo_Documento AddTipo_Documento(Tipo_Documento tipo_documento);

        Tipo_Documento UpdateTipo_Documento(Tipo_Documento tipo_documento);

        void DeleteTipo_Documento(int IdTipo_Documento);

        Tipo_Documento GetTipo_Documento(int? IdTipo_Documento);
        //========================================================================================
        //========================================================================================
        //CRUD GENERO

        IEnumerable<Genero> GetAllGeneros(string? Nombre);

        Genero AddGenero(Genero genero);

        Genero UpdateGenero(Genero genero);

        void DeleteGenero(int IdGenero);

        Genero GetGenero(int? IdGenero);
        //========================================================================================
        //========================================================================================
        //CRUD CIUDAD

        IEnumerable<Ciudad> GetAllCiudades(string? Nombre);

        Ciudad AddCiudad(Ciudad ciudad);

        Ciudad UpdateCiudad(Ciudad ciudad);

        void DeleteCiudad(int IdCiudad);

        Ciudad GetCiudad(int? IdCiudad);
        //========================================================================================
        //CRUD Perfil

        IEnumerable<Perfil> GetAllPerfiles(string? Nombre);

        Perfil AddPerfil(Perfil perfil);

        Perfil UpdatePerfil(Perfil perfil);

        void DeletePerfil(int IdPerfil);

        Perfil GetPerfil(int? IdPerfil);
        //========================================================================================
        //CRUD Rama

        IEnumerable<Rama> GetAllRamas(string? Nombre);

        Rama AddRama(Rama rama);

        Rama UpdateRama(Rama rama);

        void DeleteRama(int IdRama);

        Rama GetRama(int? IdRama);
        //========================================================================================
            //CRUD Modalidad

        IEnumerable<Modalidad> GetAllModalidades(string? Nombre);

        Modalidad AddModalidad(Modalidad modalidad);

        Modalidad UpdateModalidad(Modalidad modalidad);

        void DeleteModalidad(int IdModalidad);

        Modalidad GetModalidad(int? IdModalidad);
        //========================================================================================
        //CRUD Categoria

        IEnumerable<Categoria> GetAllCategorias(string? Nombre);

        Categoria AddCategoria(Categoria categoria);

        Categoria UpdateCategoria(Categoria categoria);

        void DeleteCategoria(int IdCategoria);

        Categoria GetCategoria(int? IdCategoria);
        //========================================================================================
       //CRUD Arbitro

 //       IEnumerable<Arbitro> GetAllArbitros(string? Nombre);  implementar buscar

        Arbitro AddArbitro(Arbitro arbitro);

        Arbitro UpdateArbitro(Arbitro arbitro);

        void DeleteArbitro(int IdArbitro);

        Arbitro GetArbitro(int? IdArbitro);

        //========================================================================================
        //CRUD Campeonato

        IEnumerable<Campeonato> GetAllCampeonatos(string? Nombre);

        Campeonato AddCampeonato(Campeonato campeonato);

        Campeonato UpdateCampeonato(Campeonato campeonato);

        void DeleteCampeonato(int IdCampeonato);

        Campeonato GetCampeonato(int? IdCampeonato);

        //========================================================================================
        //CRUD Equipo_Jugador

        IEnumerable<Equipo_Jugador> GetAllEquipo_Jugadores(string? Dorsal);

        Equipo_Jugador AddEquipo_Jugador(Equipo_Jugador equipo_Jugador);

        Equipo_Jugador UpdateEquipo_Jugador(Equipo_Jugador equipo_Jugador);

        void DeleteEquipo_Jugador(int IdEquipo_Jugador);

        Equipo_Jugador GetEquipo_Jugador(int? IdEquipo_Jugador);

        //========================================================================================
        //CRUD Equipo_Partido

        IEnumerable<Equipo_Partido> GetAllEquipo_Partidos(string? Equipo_Local);

        Equipo_Partido AddEquipo_Partido(Equipo_Partido equipo_Partido);

        Equipo_Partido UpdateEquipo_Partido(Equipo_Partido equipo_Partido);

        void DeleteEquipo_Partido(int IdEquipo_Partido);

        Equipo_Partido GetEquipo_Partido(int? IdEquipo_Partido);
        //========================================================================================
        //CRUD Equipo

        IEnumerable<Equipo> GetAllEquipos(string? Nombre);

        Equipo AddEquipo(Equipo equipo);

        Equipo UpdateEquipo(Equipo equipo);

        void DeleteEquipo(int IdEquipo);

        Equipo GetEquipo(int? IdEquipo);
        //========================================================================================



    }
}