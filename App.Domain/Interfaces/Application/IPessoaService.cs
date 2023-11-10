using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.Domain.Entities;

namespace App.Domain.Interfaces.Application {
    public interface IPessoaService {
        void Editar(Pessoa obj);
        void Deletar(int id);
        void Criar(Pessoa obj);
        Pessoa BuscarPorId(int id);
        List<Pessoa> BuscarLista();
    }
}