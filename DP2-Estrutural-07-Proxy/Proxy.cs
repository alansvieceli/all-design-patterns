using System;

namespace DP2_Estrutural_07_Proxy
{
    public class Proxy : Subject
    {
        private RealSubject _realSubject;
        
        public override void Requisicao()
        {
            if (this._realSubject == null)
            {
                this._realSubject = new RealSubject();
            }
            this._realSubject.Requisicao();
        }
    }
}