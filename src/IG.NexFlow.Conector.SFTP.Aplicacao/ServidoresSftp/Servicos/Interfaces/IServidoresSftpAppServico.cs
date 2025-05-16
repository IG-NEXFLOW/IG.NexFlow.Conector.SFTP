namespace IG.NexFlow.Conector.SFTP.Aplicacao.ServidoresSftp.Servicos.Interfaces
{
    public interface IServidoresSftpAppServico
    {
        Task ListarTodosAsync();
        Task InserirAsync();
        Task EditarAsync();
        Task RemoverAsync();
    }
}
