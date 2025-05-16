namespace IG.NexFlow.Core.Dominio.Entidades
{
    public abstract class EntidadeAuditadaBase : EntidadeBase
    {
        public virtual string Nome { get; protected set; } = string.Empty;
        public virtual bool Deletado { get; protected set; }
        public virtual bool Ativo { get; protected set; }

        protected EntidadeAuditadaBase() { }

        protected EntidadeAuditadaBase(string nome)
        {
            SetNome(nome);
            SetDeletado(false);
            SetAtivo(true);
        }

        public virtual void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception(nameof(Nome));

            if (nome.Length > 255)
                throw new Exception(nameof(Nome));

            Nome = nome;
        }

        public virtual void SetDeletado(bool deletado)
        {
            Deletado = deletado;
        }

        public virtual void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }
    }
}
