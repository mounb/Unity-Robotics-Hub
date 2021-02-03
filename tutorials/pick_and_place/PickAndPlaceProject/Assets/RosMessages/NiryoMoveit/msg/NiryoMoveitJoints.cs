//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.NiryoMoveit
{
    public class NiryoMoveitJoints : Message
    {
        public const string RosMessageName = "niryo_moveit/NiryoMoveitJoints";

        public double joint_00;
        public double joint_01;
        public double joint_02;
        public double joint_03;
        public double joint_04;
        public double joint_05;
        public Geometry.Pose pick_pose;
        public Geometry.Pose place_pose;

        public NiryoMoveitJoints()
        {
            this.joint_00 = 0.0;
            this.joint_01 = 0.0;
            this.joint_02 = 0.0;
            this.joint_03 = 0.0;
            this.joint_04 = 0.0;
            this.joint_05 = 0.0;
            this.pick_pose = new Geometry.Pose();
            this.place_pose = new Geometry.Pose();
        }

        public NiryoMoveitJoints(double joint_00, double joint_01, double joint_02, double joint_03, double joint_04, double joint_05, Geometry.Pose pick_pose, Geometry.Pose place_pose)
        {
            this.joint_00 = joint_00;
            this.joint_01 = joint_01;
            this.joint_02 = joint_02;
            this.joint_03 = joint_03;
            this.joint_04 = joint_04;
            this.joint_05 = joint_05;
            this.pick_pose = pick_pose;
            this.place_pose = place_pose;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(BitConverter.GetBytes(this.joint_00));
            listOfSerializations.Add(BitConverter.GetBytes(this.joint_01));
            listOfSerializations.Add(BitConverter.GetBytes(this.joint_02));
            listOfSerializations.Add(BitConverter.GetBytes(this.joint_03));
            listOfSerializations.Add(BitConverter.GetBytes(this.joint_04));
            listOfSerializations.Add(BitConverter.GetBytes(this.joint_05));
            listOfSerializations.AddRange(pick_pose.SerializationStatements());
            listOfSerializations.AddRange(place_pose.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            this.joint_00 = BitConverter.ToDouble(data, offset);
            offset += 8;
            this.joint_01 = BitConverter.ToDouble(data, offset);
            offset += 8;
            this.joint_02 = BitConverter.ToDouble(data, offset);
            offset += 8;
            this.joint_03 = BitConverter.ToDouble(data, offset);
            offset += 8;
            this.joint_04 = BitConverter.ToDouble(data, offset);
            offset += 8;
            this.joint_05 = BitConverter.ToDouble(data, offset);
            offset += 8;
            offset = this.pick_pose.Deserialize(data, offset);
            offset = this.place_pose.Deserialize(data, offset);

            return offset;
        }

        public override string ToString()
        {
            return "NiryoMoveitJoints: " +
            "\njoint_00: " + joint_00.ToString() +
            "\njoint_01: " + joint_01.ToString() +
            "\njoint_02: " + joint_02.ToString() +
            "\njoint_03: " + joint_03.ToString() +
            "\njoint_04: " + joint_04.ToString() +
            "\njoint_05: " + joint_05.ToString() +
            "\npick_pose: " + pick_pose.ToString() +
            "\nplace_pose: " + place_pose.ToString();
        }
    }
}