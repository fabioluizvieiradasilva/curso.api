using curso.api.Business.Entities;
using curso.api.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Infraestruture.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CursoDbContext _cursoDbContext;

        public UsuarioRepository(CursoDbContext cursoDbContext)
        {
            this._cursoDbContext = cursoDbContext;
        }

        public void Adicionar(Usuario usuario)
        {
            this._cursoDbContext.Usuarios.Add(usuario);                   
        }

        public void Commit()
        {
            this._cursoDbContext.SaveChanges();
        }
    }
}
