using System;


namespace StategyDesignPatterApp.Model
{
    interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
