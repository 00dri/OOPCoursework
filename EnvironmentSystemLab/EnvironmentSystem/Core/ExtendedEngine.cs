namespace EnvironmentSystem.Core
{
    using System;
    using Models;

    public class ExtendedEngine : Engine
    {
        protected override void Insert(EnvironmentObject obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj" + " cannot be null");
            }
            base.Insert(obj);
        }

        protected override void ExecuteEnvironmentLoop()
        {
            base.ExecuteEnvironmentLoop();
        }
    }
}
