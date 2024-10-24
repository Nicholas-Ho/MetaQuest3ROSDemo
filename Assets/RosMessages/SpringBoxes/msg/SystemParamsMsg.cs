//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.SpringBoxes
{
    [Serializable]
    public class SystemParamsMsg : Message
    {
        public const string k_RosMessageName = "spring_boxes/SystemParams";
        public override string RosMessageName => k_RosMessageName;

        public double spring_constant;
        public double damper_constant;
        public double equil_spring_length;

        public SystemParamsMsg()
        {
            this.spring_constant = 0.0;
            this.damper_constant = 0.0;
            this.equil_spring_length = 0.0;
        }

        public SystemParamsMsg(double spring_constant, double damper_constant, double equil_spring_length)
        {
            this.spring_constant = spring_constant;
            this.damper_constant = damper_constant;
            this.equil_spring_length = equil_spring_length;
        }

        public static SystemParamsMsg Deserialize(MessageDeserializer deserializer) => new SystemParamsMsg(deserializer);

        private SystemParamsMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.spring_constant);
            deserializer.Read(out this.damper_constant);
            deserializer.Read(out this.equil_spring_length);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.spring_constant);
            serializer.Write(this.damper_constant);
            serializer.Write(this.equil_spring_length);
        }

        public override string ToString()
        {
            return "SystemParamsMsg: " +
            "\nspring_constant: " + spring_constant.ToString() +
            "\ndamper_constant: " + damper_constant.ToString() +
            "\nequil_spring_length: " + equil_spring_length.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}