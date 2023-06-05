namespace GalloFlix.Interfaces;

public interface IRepository<T> where T : class
{
    // CRUD: CREATE, READ, UPDATE, DELETE
    // CREATE - Adicionar Dado
    void Create(T model);

    // READ - Leitura de Dados
    List<T> ReadAll();
    T ReadById(int? id);
    
    // UPDATE - Atualizar um Dado
    void Update(T model);

    // DELETE - Excluir Dado
    void Delete(int? id);
}
