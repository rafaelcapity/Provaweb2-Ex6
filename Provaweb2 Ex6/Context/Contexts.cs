using Provaweb2_Ex6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Provaweb2_Ex6.Context
{
    public class Contexts : DbContext
    {

        public DbSet<Aluno> Alunos{ get; set; }

    }
}