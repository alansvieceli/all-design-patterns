namespace DP3_Comportamental_05_Mediator
{
    public class Mediador : IMediador
    {
        private AlanColega _alan;
        private JaqueColega _jaque;

        public AlanColega Alan
        {
            set { _alan = value; }
        }

        public JaqueColega Jaque
        {
            set { _jaque = value; }
        }

        public void Enviar(string msg, Colega colega)
        {
            if (colega == _alan)
                _alan.Notificar(msg);
            else
                _jaque.Notificar(msg);
        }
    }
}