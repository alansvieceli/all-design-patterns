namespace DP3_Comportamental_05_Mediator
{
    public abstract class Colega
    {

        public Colega(IMediador mediador)
        {
            this.Mediador = mediador;
        }
        
        protected IMediador Mediador;

        public void Enviar(string msg)
        {
            Mediador.Enviar(msg, this);
        }
        
        public abstract void Notificar(string msg);

    }
}