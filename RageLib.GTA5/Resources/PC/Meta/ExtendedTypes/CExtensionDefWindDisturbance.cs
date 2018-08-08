using System.Collections.Generic;
using System.Linq;

using SharpDX;

namespace RageLib.Resources.GTA5.PC.Meta.ExtendedTypes
{
	public class CExtensionDefWindDisturbance : MetaStructureWrapper<PC.Meta.CExtensionDefWindDisturbance>
	{
		public MetaFile Meta;
		public uint Name;
		public Vector3 OffsetPosition;
		public Vector4 OffsetRotation;
		public int DisturbanceType;
		public int BoneTag;
		public Vector4 Size;
		public float Strength;
		public int Flags;

		public CExtensionDefWindDisturbance(MetaName metaName) : base(metaName)
		{
			this.MetaStructure = new PC.Meta.CExtensionDefWindDisturbance();
		}

		public void Parse(MetaFile meta, PC.Meta.CExtensionDefWindDisturbance CExtensionDefWindDisturbance)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefWindDisturbance;

			this.Name = CExtensionDefWindDisturbance.name;
			this.OffsetPosition = CExtensionDefWindDisturbance.offsetPosition;
			this.OffsetRotation = CExtensionDefWindDisturbance.offsetRotation;
			this.DisturbanceType = CExtensionDefWindDisturbance.disturbanceType;
			this.BoneTag = CExtensionDefWindDisturbance.boneTag;
			this.Size = CExtensionDefWindDisturbance.size;
			this.Strength = CExtensionDefWindDisturbance.strength;
			this.Flags = CExtensionDefWindDisturbance.flags;
		}

		public void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.offsetRotation = this.OffsetRotation;
			this.MetaStructure.disturbanceType = this.DisturbanceType;
			this.MetaStructure.boneTag = this.BoneTag;
			this.MetaStructure.size = this.Size;
			this.MetaStructure.strength = this.Strength;
			this.MetaStructure.flags = this.Flags;

			var enumInfos = MetaInfo.GetStructureEnumInfo(this.MetaName);
			var structureInfo = MetaInfo.GetStructureInfo(this.MetaName);
			var childStructureInfos = MetaInfo.GetStructureChildInfo(this.MetaName);

			for (int i = 0; i < enumInfos.Length; i++)
				mb.AddEnumInfo((MetaName) enumInfos[i].EnumNameHash);

			mb.AddStructureInfo((MetaName) structureInfo.StructureNameHash);


			for (int i = 0; i < childStructureInfos.Length; i++)
				mb.AddStructureInfo((MetaName) childStructureInfos[i].StructureNameHash);

			if(isRoot)
			{
				mb.AddItem(this.MetaName, this.MetaStructure);

				this.Meta = mb.GetMeta();
			}
		}
	}
}
