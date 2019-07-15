using ApnCore_CRUD.Models;
using System.Collections.Generic;

namespace ApnCore_CRUD.Acesso_a_Dados
{
	public interface IFuncionarioDAL
	{
		IEnumerable<Funcionario> GetAllFuncionarios();
		void AddFuncionario(Funcionario funcionario);
		void UpdateFuncionario(Funcionario funcionario);
		Funcionario GetFuncionario(int? id);
		void DeleteFuncionario(int? id);
	}
}
