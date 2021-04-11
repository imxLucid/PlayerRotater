namespace PlayerRotater.ControlSchemes.Interface
{

    using UnityEngine;

    internal interface IControlScheme
    {

        /// <summary>
        ///     Handle Input for this control scheme and return if we need to align tracking or not
        /// </summary>
        /// <param name="playerTransform">transform of the player</param>
        /// <param name="cameraTransform">transform of the camera</param>
        /// <param name="flyingSpeed">current flying speed</param>
        /// <param name="rotationSpeed">current rotation speed</param>
        /// <param name="origin">origin to rotate around</param>
        /// <returns>whether to align tracking to player or not</returns>
        bool HandleInput(Transform playerTransform, Transform cameraTransform, float flyingSpeed, float rotationSpeed, Transform origin);

    }

}