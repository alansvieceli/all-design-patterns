namespace DP3_Comportamental_01_ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler sucessor;

        public void SetSucessor(Handler s)
        {
            this.sucessor = s;
        }

        public abstract void HandleRequest(int request);
    }
}