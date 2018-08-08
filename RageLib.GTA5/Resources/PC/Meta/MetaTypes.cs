using System.Collections.Generic;
using System.Runtime.InteropServices;
using SharpDX;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Meta
{
    public class MetaInfo
    {
        public static EnumInfo GetEnumInfo(MetaName name)
        {
            switch (name)
            {
                case (MetaName)(1991964615):
                    return new EnumInfo(1991964615, 1866031916, 1342189048, 0, new ResourceSimpleArray<EnumEntryInfo>() {
                        new EnumEntryInfo(189734893, 0),
                        new EnumEntryInfo(571047911, 1),
                        new EnumEntryInfo(130075505, 2),
                        new EnumEntryInfo(1580165652, 3),
                        new EnumEntryInfo(-133882255, 4)
                    });

                case (MetaName)(1264241711):
                    return new EnumInfo(1264241711, 1856311430, 1342281840, 0, new ResourceSimpleArray<EnumEntryInfo>() {
                        new EnumEntryInfo(-1035445316, 0),
                        new EnumEntryInfo(-1910323114, 1),
                        new EnumEntryInfo(-1740892308, 2),
                        new EnumEntryInfo(315427988, 3),
                        new EnumEntryInfo(-2130417407, 4),
                        new EnumEntryInfo(2106806081, 5),
                        new EnumEntryInfo(1868383667, 6)
                    });

                case (MetaName)(648413703):
                    return new EnumInfo(648413703, -2094609585, 1342281944, 0, new ResourceSimpleArray<EnumEntryInfo>() {
                        new EnumEntryInfo(1943361227, 0),
                        new EnumEntryInfo(-301350505, 1),
                        new EnumEntryInfo(515598709, 2),
                        new EnumEntryInfo(329627604, 3)
                    });

                case (MetaName)(-721371006):
                    return new EnumInfo(-721371006, 671739257, 1342198832, 0, new ResourceSimpleArray<EnumEntryInfo>() {
                        new EnumEntryInfo(1849703770, 0),
                        new EnumEntryInfo(-123924556, 1),
                        new EnumEntryInfo(549935372, 2)
                    });

                case (MetaName)(700327466):
                    return new EnumInfo(700327466, -1480371201, 1342197544, 0, new ResourceSimpleArray<EnumEntryInfo>() {
                        new EnumEntryInfo(-1044656072, 0),
                        new EnumEntryInfo(-1973473904, 1),
                        new EnumEntryInfo(-1674337659, 2),
                        new EnumEntryInfo(-1037130927, 3),
                        new EnumEntryInfo(-2129358041, 4),
                        new EnumEntryInfo(-893607308, 5),
                        new EnumEntryInfo(-1668902425, 6),
                        new EnumEntryInfo(2004780781, 7),
                        new EnumEntryInfo(536864854, 8),
                        new EnumEntryInfo(-853902128, 9),
                        new EnumEntryInfo(1653545417, 10),
                        new EnumEntryInfo(763077056, 11),
                        new EnumEntryInfo(-604739603, 12),
                        new EnumEntryInfo(1601179199, 13),
                        new EnumEntryInfo(-1711814966, 14),
                        new EnumEntryInfo(-804649776, 15),
                        new EnumEntryInfo(-1137070616, 16),
                        new EnumEntryInfo(1269249358, 17),
                        new EnumEntryInfo(-1912826172, 18),
                        new EnumEntryInfo(196435285, 19),
                        new EnumEntryInfo(-2047335908, 20),
                        new EnumEntryInfo(-194258362, 21),
                        new EnumEntryInfo(324643703, 22),
                        new EnumEntryInfo(-577950923, 23),
                        new EnumEntryInfo(-868519637, 24),
                        new EnumEntryInfo(626032513, 25),
                        new EnumEntryInfo(1524211135, 26),
                        new EnumEntryInfo(-932217619, 27),
                        new EnumEntryInfo(-990403905, 28),
                        new EnumEntryInfo(1111379709, 29),
                        new EnumEntryInfo(176469077, 30)
                    });

                case (MetaName)(1294270217):
                    return new EnumInfo(1294270217, -780397138, 1342218208, 0, new ResourceSimpleArray<EnumEntryInfo>() {
                        new EnumEntryInfo(1101797524, 0),
                        new EnumEntryInfo(846330484, 1),
                        new EnumEntryInfo(-1092349856, 2)
                    });

                case (MetaName)(1931949281):
                    return new EnumInfo(1931949281, -755366114, 1342214264, 0, new ResourceSimpleArray<EnumEntryInfo>() {
                        new EnumEntryInfo(676250331, 0),
                        new EnumEntryInfo(-1895380732, 1),
                        new EnumEntryInfo(2057886646, 2),
                        new EnumEntryInfo(1816804348, 3),
                        new EnumEntryInfo(152140774, 4),
                        new EnumEntryInfo(2088805984, 5),
                        new EnumEntryInfo(1098824079, 6),
                        new EnumEntryInfo(1492299290, 7)
                    });

                case (MetaName)(-2028452237):
                    return new EnumInfo(-2028452237, -7494951, 1342210016, 0, new ResourceSimpleArray<EnumEntryInfo>() {
                        new EnumEntryInfo(665241531, 0),
                        new EnumEntryInfo(462992848, 1)
                    });

                case (MetaName)(-1250496436):
                    return new EnumInfo(-1250496436, 1585854303, 1342199888, 0, new ResourceSimpleArray<EnumEntryInfo>() {
                        new EnumEntryInfo(997866013, 0)
                    });

                default: return null;
            }
        }

        public static StructureInfo GetStructureInfo(MetaName name)
        {
            switch (name)
            {
                case MetaName.CMapTypes:
                    return new StructureInfo(-645155487, -1686092076, 768, 0, 1342188712, 80, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(-243368152, 8, StructureEntryDataType.Array, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(25836315, 24, StructureEntryDataType.Array, 0, 2, 0),
                        new StructureEntryInfo(-421429484, 40, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1013942340, 48, StructureEntryDataType.Array, 0, 5, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, 1185771007),
                        new StructureEntryInfo(1709823211, 64, StructureEntryDataType.Array, 0, 7, 0)
                    });

                case MetaName.CBaseArchetypeDef:
                    return new StructureInfo(-2099839869, -1883579740, 1024, 0, 1342188440, 144, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-1082859609, 8, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 12, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1813324772, 16, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-638614986, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-410343912, 48, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-703040769, 64, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-2098674210, 80, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1386390708, 84, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-421429484, 88, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1976702369, 92, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(424089489, 96, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-65030405, 100, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-741926916, 104, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(110101682, 108, StructureEntryDataType.IntEnum, 0, 0, 1991964615),
                        new StructureEntryInfo(-1703426107, 112, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(-243368152, 120, StructureEntryDataType.Array, 0, 15, 0)
                    });

                case MetaName.rage__fwInstancedMapData:
                    return new StructureInfo(-246803010, 1836780118, 768, 0, 1342178928, 48, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(2142127586, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, -1174104208),
                        new StructureEntryInfo(-743492768, 16, StructureEntryDataType.Array, 0, 1, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, 2085051229),
                        new StructureEntryInfo(255292381, 32, StructureEntryDataType.Array, 0, 3, 0)
                    });

                case MetaName.CLODLight:
                    return new StructureInfo(-2018753224, -1969778068, 768, 0, 1342178320, 136, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, -489959468),
                        new StructureEntryInfo(887068712, 8, StructureEntryDataType.Array, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-865597720, 24, StructureEntryDataType.Array, 0, 2, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(733168314, 40, StructureEntryDataType.Array, 0, 4, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1182549018, 56, StructureEntryDataType.Array, 0, 6, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1048674328, 72, StructureEntryDataType.Array, 0, 8, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(1163671864, 88, StructureEntryDataType.Array, 0, 10, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-1133073216, 104, StructureEntryDataType.Array, 0, 12, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-2002603525, 120, StructureEntryDataType.Array, 0, 14, 0)
                    });

                case MetaName.CDistantLODLight:
                    return new StructureInfo(2033467892, -1474058877, 768, 0, 1342178736, 48, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, -489959468),
                        new StructureEntryInfo(18243940, 8, StructureEntryDataType.Array, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(194542898, 24, StructureEntryDataType.Array, 0, 2, 0),
                        new StructureEntryInfo(-586076085, 40, StructureEntryDataType.UnsignedShort, 0, 0, 0),
                        new StructureEntryInfo(2052871693, 42, StructureEntryDataType.UnsignedShort, 0, 0, 0)
                    });

                case MetaName.CBlockDesc:
                    return new StructureInfo(-1222611382, 2015795449, 768, 0, 1342178832, 72, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(1757576755, 0, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 4, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.CharPointer, 0, 0, 0),
                        new StructureEntryInfo(1983184981, 24, StructureEntryDataType.CharPointer, 0, 0, 0),
                        new StructureEntryInfo(-1945763472, 40, StructureEntryDataType.CharPointer, 0, 0, 0),
                        new StructureEntryInfo(258444835, 56, StructureEntryDataType.CharPointer, 0, 0, 0)
                    });

                case MetaName.CMapData:
                    return new StructureInfo(-749125722, -846865625, 1024, 0, 1342177904, 512, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-1449376175, 12, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 16, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1785155637, 20, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-584941025, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-1574001867, 48, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(477478129, 64, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1829192759, 80, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(-861170937, 96, StructureEntryDataType.Array, 0, 8, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, 372253349),
                        new StructureEntryInfo(-1358983915, 112, StructureEntryDataType.Array, 0, 10, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, 975711773),
                        new StructureEntryInfo(-311376364, 128, StructureEntryDataType.Array, 4, 12, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, -1553183059),
                        new StructureEntryInfo(2132383965, 144, StructureEntryDataType.Array, 4, 14, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(949589348, 160, StructureEntryDataType.Array, 0, 16, 0),
                        new StructureEntryInfo(-1725899735, 176, StructureEntryDataType.Structure, 0, 0, -246803010),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, 1733268304),
                        new StructureEntryInfo(-1348715559, 224, StructureEntryDataType.Array, 0, 19, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, 1860713439),
                        new StructureEntryInfo(-1040143540, 240, StructureEntryDataType.Array, 0, 21, 0),
                        new StructureEntryInfo(1774371066, 256, StructureEntryDataType.Structure, 0, 0, -2018753224),
                        new StructureEntryInfo(-1340500655, 392, StructureEntryDataType.Structure, 0, 0, 2033467892),
                        new StructureEntryInfo(-466364547, 440, StructureEntryDataType.Structure, 0, 0, -1222611382)
                    });

                case MetaName.CEntityDef:
                    return new StructureInfo(-833612669, 1825799514, 1024, 0, 1342209744, 128, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-1608277972, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 12, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1703186835, 16, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(18243940, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(2010988560, 48, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(-1667029449, 64, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(284916802, 68, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-661507651, 72, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1082859609, 76, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-896054323, 80, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1821316885, 84, StructureEntryDataType.IntEnum, 0, 0, 1264241711),
                        new StructureEntryInfo(-1501057911, 88, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(647098393, 92, StructureEntryDataType.IntEnum, 0, 0, 648413703),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(-243368152, 96, StructureEntryDataType.Array, 0, 13, 0),
                        new StructureEntryInfo(415356295, 112, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(599844163, 116, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(1015358759, 120, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case MetaName.CTimeCycleModifier:
                    return new StructureInfo(1733268304, -1611546519, 1024, 0, 1342178768, 64, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1731020657, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-1740160456, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-1347409643, 48, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(332484516, 52, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(625204231, 56, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(380604338, 60, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case MetaName.CTimeArchetypeDef:
                    return new StructureInfo(1991296364, -1774347386, 1024, 0, 1342198896, 160, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-1082859609, 8, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 12, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1813324772, 16, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-638614986, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-410343912, 48, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-703040769, 64, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-2098674210, 80, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1386390708, 84, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-421429484, 88, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1976702369, 92, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(424089489, 96, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-65030405, 100, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-741926916, 104, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(110101682, 108, StructureEntryDataType.IntEnum, 0, 0, 1991964615),
                        new StructureEntryInfo(-1703426107, 112, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(-243368152, 120, StructureEntryDataType.Array, 0, 15, 0),
                        new StructureEntryInfo(-2046175956, 144, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case MetaName.CExtensionDefLightEffect:
                    return new StructureInfo(663891011, -1858767399, 1024, 0, 1342231248, 48, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, -179625349),
                        new StructureEntryInfo(274177522, 32, StructureEntryDataType.Array, 0, 2, 0)
                    });

                case MetaName.CLightAttrDef:
                    return new StructureInfo(-179625349, -1931707028, 768, 0, 1342208448, 160, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(967189988, 8, StructureEntryDataType.ArrayOfBytes, 0, 0, 3),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(1541149667, 20, StructureEntryDataType.ArrayOfBytes, 0, 2, 3),
                        new StructureEntryInfo(-465274094, 23, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-271738563, 24, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 28, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(702019504, 32, StructureEntryDataType.SignedShort, 0, 0, 0),
                        new StructureEntryInfo(482065968, 34, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-1793336044, 35, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-2046175956, 36, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-865597720, 40, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(733168314, 44, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1689591312, 48, StructureEntryDataType.ArrayOfBytes, 0, 13, 4),
                        new StructureEntryInfo(-622251143, 64, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-1114325446, 65, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-1948853569, 66, StructureEntryDataType.SignedShort, 0, 0, 0),
                        new StructureEntryInfo(-773364001, 68, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(689780512, 72, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(2029533327, 76, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-2010973234, 80, StructureEntryDataType.ArrayOfBytes, 0, 21, 3),
                        new StructureEntryInfo(643049222, 83, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-1286768649, 84, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1705000075, 88, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1536118046, 92, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1307926275, 96, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(1944267876, 97, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-144080248, 98, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(2066998816, 99, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(954647178, 100, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-2002603525, 104, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1774608013, 108, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(887068712, 112, StructureEntryDataType.ArrayOfBytes, 0, 34, 3),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1905325143, 124, StructureEntryDataType.ArrayOfBytes, 0, 36, 3),
                        new StructureEntryInfo(1163671864, 136, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-119938236, 140, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(759134656, 144, StructureEntryDataType.ArrayOfBytes, 0, 40, 3),
                        new StructureEntryInfo(1076718994, 156, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case MetaName.CMloInstanceDef:
                    return new StructureInfo(164374718, -2143390544, 1024, 0, 1342178320, 160, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-1608277972, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 12, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1703186835, 16, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(18243940, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(2010988560, 48, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(-1667029449, 64, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(284916802, 68, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-661507651, 72, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1082859609, 76, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-896054323, 80, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1821316885, 84, StructureEntryDataType.IntEnum, 0, 0, 1264241711),
                        new StructureEntryInfo(-1501057911, 88, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(647098393, 92, StructureEntryDataType.IntEnum, 0, 0, 648413703),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(-243368152, 96, StructureEntryDataType.Array, 0, 13, 0),
                        new StructureEntryInfo(415356295, 112, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(599844163, 116, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(1015358759, 120, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1793336044, 128, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-2107316687, 132, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1407157833, 136, StructureEntryDataType.Array, 0, 20, 0),
                        new StructureEntryInfo(528711607, 152, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-533001046, 156, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case (MetaName)(975711773):
                    return new StructureInfo(975711773, 1831736438, 256, 0, 1342178800, 16, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(48026296, 0, StructureEntryDataType.SignedShort, 0, 0, 0),
                        new StructureEntryInfo(896907229, 2, StructureEntryDataType.SignedShort, 0, 0, 0),
                        new StructureEntryInfo(1597508449, 4, StructureEntryDataType.SignedShort, 0, 0, 0),
                        new StructureEntryInfo(-559535774, 6, StructureEntryDataType.SignedShort, 0, 0, 0),
                        new StructureEntryInfo(-1440356635, 8, StructureEntryDataType.SignedShort, 0, 0, 0),
                        new StructureEntryInfo(168013536, 10, StructureEntryDataType.SignedShort, 0, 0, 0),
                        new StructureEntryInfo(-809689303, 12, StructureEntryDataType.SignedShort, 0, 0, 0),
                        new StructureEntryInfo(1351095745, 14, StructureEntryDataType.SignedShort, 0, 0, 0)
                    });

                case (MetaName)(-1553183059):
                    return new StructureInfo(-1553183059, 1172796107, 1024, 0, 1342178928, 64, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(2028577215, 0, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-1074401301, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-1852213925, 32, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(120498671, 40, StructureEntryDataType.DataBlockPointer, 4, 3, 2),
                        new StructureEntryInfo(853977995, 48, StructureEntryDataType.UnsignedShort, 0, 0, 0),
                        new StructureEntryInfo(-1957272218, 50, StructureEntryDataType.UnsignedShort, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 52, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case MetaName.CMloArchetypeDef:
                    return new StructureInfo(273704021, 937664754, 1024, 0, 1342234080, 240, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-1082859609, 8, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 12, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1813324772, 16, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-638614986, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-410343912, 48, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-703040769, 64, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-2098674210, 80, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1386390708, 84, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-421429484, 88, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1976702369, 92, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(424089489, 96, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-65030405, 100, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-741926916, 104, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(110101682, 108, StructureEntryDataType.IntEnum, 0, 0, 1991964615),
                        new StructureEntryInfo(-1703426107, 112, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(-243368152, 120, StructureEntryDataType.Array, 0, 15, 0),
                        new StructureEntryInfo(-704127384, 144, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(-861170937, 152, StructureEntryDataType.Array, 0, 18, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, 186126833),
                        new StructureEntryInfo(-853485656, 168, StructureEntryDataType.Array, 0, 20, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, -1722780982),
                        new StructureEntryInfo(-1980241518, 184, StructureEntryDataType.Array, 0, 22, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, -693659143),
                        new StructureEntryInfo(1169996080, 200, StructureEntryDataType.Array, 0, 24, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, 807246248),
                        new StructureEntryInfo(-1348715559, 216, StructureEntryDataType.Array, 0, 26, 0)
                    });

                case MetaName.CMloRoomDef:
                    return new StructureInfo(186126833, -409539051, 1024, 0, 1342235568, 112, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.CharPointer, 0, 0, 0),
                        new StructureEntryInfo(-638614986, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-410343912, 48, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-361519605, 64, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1570643799, 68, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-1039642468, 72, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 76, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1105339827, 80, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-2107316687, 84, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(552849982, 88, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1912262356, 96, StructureEntryDataType.Array, 0, 10, 0)
                    });

                case MetaName.CMloPortalDef:
                    return new StructureInfo(-1722780982, 1110221513, 768, 0, 1342235760, 64, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-193932547, 8, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1687906783, 12, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 16, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1185490713, 20, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-650555608, 24, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1093790004, 28, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1329770163, 32, StructureEntryDataType.Array, 0, 6, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1912262356, 48, StructureEntryDataType.Array, 0, 8, 0)
                    });

                case MetaName.CMloTimeCycleModifier:
                    return new StructureInfo(807246248, 838874674, 1024, 0, 1342236180, 48, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(953812642, 16, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(-1347409643, 32, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(332484516, 36, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(625204231, 40, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(380604338, 44, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case MetaName.CExtensionDefParticleEffect:
                    return new StructureInfo(975627745, 466596385, 1024, 0, 1342183680, 96, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1389511464, 32, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(1920790105, 48, StructureEntryDataType.CharPointer, 0, 0, 0),
                        new StructureEntryInfo(529104057, 64, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(702019504, 68, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(1342385372, 72, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-596433036, 76, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 80, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(-380371671, 84, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case MetaName.CCompositeEntityType:
                    return new StructureInfo(1185771007, 659539004, 1024, 0, 1342183008, 304, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-1393810754, 0, StructureEntryDataType.ArrayOfChars, 0, 0, 64),
                        new StructureEntryInfo(-1082859609, 64, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 68, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1813324772, 72, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-638614986, 80, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-410343912, 96, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-703040769, 112, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-2098674210, 128, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(226559569, 136, StructureEntryDataType.ArrayOfChars, 0, 0, 64),
                        new StructureEntryInfo(-1253849152, 200, StructureEntryDataType.ArrayOfChars, 0, 0, 64),
                        new StructureEntryInfo(-1831995606, 264, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(2059586669, 268, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-1796973938, 272, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, 1980345114),
                        new StructureEntryInfo(212063203, 280, StructureEntryDataType.Array, 0, 13, 0)
                    });

                case (MetaName)(1980345114):
                    return new StructureInfo(1980345114, -184471285, 768, 0, 1342184416, 216, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(1027851728, 0, StructureEntryDataType.ArrayOfChars, 0, 0, 64),
                        new StructureEntryInfo(1300132907, 64, StructureEntryDataType.ArrayOfChars, 0, 0, 64),
                        new StructureEntryInfo(1544926406, 128, StructureEntryDataType.ArrayOfChars, 0, 0, 64),
                        new StructureEntryInfo(-1152589889, 192, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-2130747926, 196, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, -864638612),
                        new StructureEntryInfo(-1009446064, 200, StructureEntryDataType.Array, 0, 5, 0)
                    });

                case (MetaName)(-864638612):
                    return new StructureInfo(-864638612, 1724963966, 1024, 0, 1342183248, 160, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(529104057, 0, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-618491720, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1710928362, 32, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(702019504, 48, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1073120873, 52, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1600588195, 56, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-860564982, 60, StructureEntryDataType.Boolean, 0, 0, 0),
                        new StructureEntryInfo(-1770063756, 61, StructureEntryDataType.ArrayOfChars, 0, 0, 64),
                        new StructureEntryInfo(1567144545, 128, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-846792988, 132, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-718424939, 136, StructureEntryDataType.Boolean, 0, 0, 0),
                        new StructureEntryInfo(1304072655, 137, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(23853287, 138, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-2069856334, 139, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(1080281337, 144, StructureEntryDataType.Float_XYZ, 0, 0, 0)
                    });

                case MetaName.CExtensionDefAudioCollisionSettings:
                    return new StructureInfo(366926375, -1593069796, 1024, 0, 1342198712, 48, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-1526810889, 32, StructureEntryDataType.Hash, 0, 0, 0)
                    });

                case MetaName.CExtensionDefSpawnPoint:
                    return new StructureInfo(-994904520, -1217626575, 1024, 0, 1342193376, 96, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1389511464, 32, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(-33719681, 48, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-1547807107, 52, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-903846487, 56, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(560567274, 60, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(2090738474, 64, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(286077157, 68, StructureEntryDataType.IntEnum, 0, 0, -721371006),
                        new StructureEntryInfo(-596433036, 72, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(213640539, 76, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1337695475, 80, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-2065946849, 84, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-1329297961, 85, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 88, StructureEntryDataType.IntFlags2, 0, 32, 700327466),
                        new StructureEntryInfo(1331010150, 92, StructureEntryDataType.Boolean, 0, 0, 0),
                        new StructureEntryInfo(-760387109, 93, StructureEntryDataType.Boolean, 0, 0, 0),
                        new StructureEntryInfo(178074428, 94, StructureEntryDataType.Boolean, 0, 0, 0)
                    });

                case MetaName.CExtensionDefAudioEmitter:
                    return new StructureInfo(637823035, 15929839, 1024, 0, 1342226184, 64, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1389511464, 32, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(-1312743848, 48, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case MetaName.CExtensionDefExplosionEffect:
                    return new StructureInfo(104349545, -1454600512, 1024, 0, 1342225904, 80, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1389511464, 32, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(-993578381, 48, StructureEntryDataType.CharPointer, 0, 0, 0),
                        new StructureEntryInfo(702019504, 64, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1641933245, 68, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(-915852286, 72, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 76, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case MetaName.CExtensionDefLadder:
                    return new StructureInfo(-2112007135, 1978210597, 1024, 0, 1342224320, 96, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-287268170, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1281216666, 48, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1330140418, 64, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(932754174, 80, StructureEntryDataType.IntEnum, 0, 0, 1294270217),
                        new StructureEntryInfo(-1092328110, 84, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(564839673, 88, StructureEntryDataType.Boolean, 0, 0, 0),
                        new StructureEntryInfo(923729576, 89, StructureEntryDataType.Boolean, 0, 0, 0)
                    });

                case MetaName.CExtensionDefBuoyancy:
                    return new StructureInfo(749982947, -1911927368, 1024, 0, 1342226400, 32, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0)
                    });

                case MetaName.CExtensionDefExpression:
                    return new StructureInfo(-424446217, 24441706, 1024, 0, 1342200352, 48, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1095612811, 32, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1573835099, 36, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-1528490137, 40, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1562817888, 44, StructureEntryDataType.Boolean, 0, 0, 0)
                    });

                case MetaName.CExtensionDefLightShaft:
                    return new StructureInfo(-1575970243, -1768537898, 1024, 0, 1342208440, 176, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-992372269, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-1901089412, 48, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-1602236132, 64, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-44594482, 80, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(887068712, 96, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1441249296, 112, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1786895047, 116, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1616789093, 120, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(120454521, 124, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1297365553, 128, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(75548206, 132, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(40301253, 136, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(475013030, 140, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-380371671, 144, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-271738563, 148, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-465274094, 152, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 156, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(235100599, 160, StructureEntryDataType.IntEnum, 0, 0, 1931949281),
                        new StructureEntryInfo(-273791707, 164, StructureEntryDataType.IntEnum, 0, 0, -2028452237),
                        new StructureEntryInfo(187712958, 168, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(59101696, 172, StructureEntryDataType.Boolean, 0, 0, 0)
                    });

                case (MetaName)(-489959468):
                    return new StructureInfo(-489959468, -1543570224, 512, 0, 1342180536, 12, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-1828477467, 0, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-2137718520, 4, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1235194722, 8, StructureEntryDataType.Float, 0, 0, 0)
                    });
/*
                case MetaName.CBaseArchetypeDef:
                    return new StructureInfo(-2099839869, -1942623804, 1024, 0, 1342179920, 128, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-1082859609, 8, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 12, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1813324772, 16, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-638614986, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-410343912, 48, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-703040769, 64, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-2098674210, 80, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1386390708, 84, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-421429484, 88, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1976702369, 92, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(424089489, 96, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-65030405, 100, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-741926916, 104, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(-243368152, 112, StructureEntryDataType.Array, 0, 13, 0)
                    });
*/
                case MetaName.CExtensionDefDoor:
                    return new StructureInfo(1965932561, -1623365911, 1024, 0, 1342251728, 48, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1979299226, 32, StructureEntryDataType.Boolean, 0, 0, 0),
                        new StructureEntryInfo(-1090394949, 33, StructureEntryDataType.Boolean, 0, 0, 0),
                        new StructureEntryInfo(-1538180952, 34, StructureEntryDataType.Boolean, 0, 0, 0),
                        new StructureEntryInfo(2100360280, 36, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(770433283, 40, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(224069936, 44, StructureEntryDataType.Hash, 0, 0, 0)
                    });

                case MetaName.CMloEntitySet:
                    return new StructureInfo(-693659143, -114755709, 768, 0, 1342219296, 48, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-570678767, 16, StructureEntryDataType.Array, 0, 1, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.StructurePointer, 0, 0, 0),
                        new StructureEntryInfo(-861170937, 32, StructureEntryDataType.Array, 0, 3, 0)
                    });

                case MetaName.CExtensionDefSpawnPointOverride:
                    return new StructureInfo(-1578105176, -1743091423, 1024, 0, 1342261272, 64, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(191322199, 32, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(591476992, 36, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-1606928773, 37, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(1713610519, 40, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1518141539, 44, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-1362285978, 48, StructureEntryDataType.IntEnum, 0, 0, -721371006),
                        new StructureEntryInfo(1264718594, 52, StructureEntryDataType.IntFlags2, 0, 32, 700327466),
                        new StructureEntryInfo(-1150617182, 56, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-221369102, 60, StructureEntryDataType.Float, 0, 0, 0)
                    });

                case MetaName.CExtensionDefWindDisturbance:
                    return new StructureInfo(569228403, -323428379, 1024, 0, 1342232240, 96, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1389511464, 32, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(-492258926, 48, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(702019504, 52, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(-1068310873, 64, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(-14924249, 80, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 84, StructureEntryDataType.SignedInt, 0, 0, 0)
                    });

                case MetaName.CCarGen:
                    return new StructureInfo(1860713439, -1949729035, 1024, 0, 1342180384, 80, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(18243940, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(735213009, 32, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(979440342, 36, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(124715667, 40, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1118961391, 44, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 48, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1429703670, 52, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(1254848286, 56, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(1880965569, 60, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(1719152247, 64, StructureEntryDataType.SignedInt, 0, 0, 0),
                        new StructureEntryInfo(911358791, 68, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-2141352176, 72, StructureEntryDataType.SignedByte, 0, 0, 0)
                    });

                case MetaName.rage__spdAABB:
                    return new StructureInfo(-210245432, 1158138379, 1024, 0, 1342180056, 32, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-30349581, 0, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(1616931012, 16, StructureEntryDataType.Float_XYZW, 0, 0, 0)
                    });

                case MetaName.rage__fwGrassInstanceListDef:
                    return new StructureInfo(2085051229, 941808164, 1024, 0, 1342179376, 96, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(1859041902, 0, StructureEntryDataType.Structure, 0, 0, -210245432),
                        new StructureEntryInfo(-1603907866, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-1608277972, 48, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-1082859609, 52, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(-2078694230, 56, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1405992723, 60, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-953491718, 64, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, -309922526),
                        new StructureEntryInfo(470289337, 72, StructureEntryDataType.Array, 36, 7, 0)
                    });

                case MetaName.rage__fwGrassInstanceListDef__InstanceData:
                    return new StructureInfo(-309922526, -1554588931, 256, 0, 1342179216, 16, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedShort, 0, 0, 0),
                        new StructureEntryInfo(210930065, 0, StructureEntryDataType.ArrayOfBytes, 0, 0, 3),
                        new StructureEntryInfo(-1156901904, 6, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(273792636, 7, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(1308845671, 8, StructureEntryDataType.ArrayOfBytes, 0, 4, 3),
                        new StructureEntryInfo(1018839014, 11, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(-1298588732, 12, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.UnsignedByte, 0, 0, 0),
                        new StructureEntryInfo(1592782806, 13, StructureEntryDataType.ArrayOfBytes, 0, 8, 3)
                    });

                case MetaName.CExtensionDefProcObject:
                    return new StructureInfo(-1729775384, -329575405, 1024, 0, 1342185152, 80, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(-661321981, 16, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(406390660, 32, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1814053978, 36, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(370899326, 40, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-632053943, 44, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(803384552, 48, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-381910451, 52, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(147400493, 56, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1703384932, 60, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-405064741, 64, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1951307499, 68, StructureEntryDataType.UnsignedInt, 0, 0, 0),
                        new StructureEntryInfo(1741842546, 72, StructureEntryDataType.UnsignedInt, 0, 0, 0)
                    });

                case MetaName.rage__phVerletClothCustomBounds:
                    return new StructureInfo(847348117, 2075461750, 768, 0, 1342199688, 32, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(-421429484, 8, StructureEntryDataType.Hash, 0, 0, 0),
                        new StructureEntryInfo(256, 0, StructureEntryDataType.Structure, 0, 0, 1701774085),
                        new StructureEntryInfo(-747911511, 16, StructureEntryDataType.Array, 0, 1, 0)
                    });

                case (MetaName)(1701774085):
                    return new StructureInfo(1701774085, -1435191956, 1024, 0, 1342198960, 96, 0, new ResourceSimpleArray<StructureEntryInfo>() {
                        new StructureEntryInfo(1481791743, 0, StructureEntryDataType.CharPointer, 0, 0, 0),
                        new StructureEntryInfo(-1923768401, 16, StructureEntryDataType.Float_XYZW, 0, 0, 0),
                        new StructureEntryInfo(210930065, 32, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(-695619201, 48, StructureEntryDataType.Float_XYZ, 0, 0, 0),
                        new StructureEntryInfo(1996975203, 64, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-1059782414, 68, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(-2131084222, 72, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(629093761, 76, StructureEntryDataType.Float, 0, 0, 0),
                        new StructureEntryInfo(1264718594, 80, StructureEntryDataType.IntFlags2, 0, 32, -1250496436)
                    });

                default: return null;
            }
        }
        public static EnumInfo[] GetStructureEnumInfo(MetaName name)
        {
            var enumInfos = new List<EnumInfo>();

            switch (name)
            {
                case MetaName.CMapTypes:
                    {
                        break;
                    }
                case MetaName.CBaseArchetypeDef:
                    {
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1991964615)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1991964615)));
                        break;
                    }
                case MetaName.rage__fwInstancedMapData:
                    {
                        break;
                    }
                case MetaName.CLODLight:
                    {
                        break;
                    }
                case MetaName.CDistantLODLight:
                    {
                        break;
                    }
                case MetaName.CBlockDesc:
                    {
                        break;
                    }
                case MetaName.CMapData:
                    {
                        break;
                    }
                case MetaName.CEntityDef:
                    {
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1264241711)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(648413703)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1264241711)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(648413703)));
                        break;
                    }
                case MetaName.CTimeCycleModifier:
                    {
                        break;
                    }
                case MetaName.CTimeArchetypeDef:
                    {
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1991964615)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1991964615)));
                        break;
                    }
                case MetaName.CExtensionDefLightEffect:
                    {
                        break;
                    }
                case MetaName.CLightAttrDef:
                    {
                        break;
                    }
                case MetaName.CMloInstanceDef:
                    {
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1264241711)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(648413703)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1264241711)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(648413703)));
                        break;
                    }
                case (MetaName)(975711773):
                    {
                        break;
                    }
                case (MetaName)(-1553183059):
                    {
                        break;
                    }
                case MetaName.CMloArchetypeDef:
                    {
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1991964615)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1991964615)));
                        break;
                    }
                case MetaName.CMloRoomDef:
                    {
                        break;
                    }
                case MetaName.CMloPortalDef:
                    {
                        break;
                    }
                case MetaName.CMloTimeCycleModifier:
                    {
                        break;
                    }
                case MetaName.CExtensionDefParticleEffect:
                    {
                        break;
                    }
                case MetaName.CCompositeEntityType:
                    {
                        break;
                    }
                case (MetaName)(1980345114):
                    {
                        break;
                    }
                case (MetaName)(-864638612):
                    {
                        break;
                    }
                case MetaName.CExtensionDefAudioCollisionSettings:
                    {
                        break;
                    }
                case MetaName.CExtensionDefSpawnPoint:
                    {
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(-721371006)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(700327466)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(-721371006)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(700327466)));
                        break;
                    }
                case MetaName.CExtensionDefAudioEmitter:
                    {
                        break;
                    }
                case MetaName.CExtensionDefExplosionEffect:
                    {
                        break;
                    }
                case MetaName.CExtensionDefLadder:
                    {
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1294270217)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1294270217)));
                        break;
                    }
                case MetaName.CExtensionDefBuoyancy:
                    {
                        break;
                    }
                case MetaName.CExtensionDefExpression:
                    {
                        break;
                    }
                case MetaName.CExtensionDefLightShaft:
                    {
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1931949281)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(-2028452237)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(1931949281)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(-2028452237)));
                        break;
                    }
                case (MetaName)(-489959468):
                    {
                        break;
                    }
                case MetaName.CExtensionDefDoor:
                    {
                        break;
                    }
                case MetaName.CMloEntitySet:
                    {
                        break;
                    }
                case MetaName.CExtensionDefSpawnPointOverride:
                    {
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(-721371006)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(700327466)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(-721371006)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(700327466)));
                        break;
                    }
                case MetaName.CExtensionDefWindDisturbance:
                    {
                        break;
                    }
                case MetaName.CCarGen:
                    {
                        break;
                    }
                case MetaName.rage__spdAABB:
                    {
                        break;
                    }
                case MetaName.rage__fwGrassInstanceListDef:
                    {
                        break;
                    }
                case MetaName.rage__fwGrassInstanceListDef__InstanceData:
                    {
                        break;
                    }
                case MetaName.CExtensionDefProcObject:
                    {
                        break;
                    }
                case MetaName.rage__phVerletClothCustomBounds:
                    {
                        break;
                    }
                case (MetaName)(1701774085):
                    {
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(-1250496436)));
                        enumInfos.Add(MetaInfo.GetEnumInfo((MetaName)(-1250496436)));
                        break;
                    }
                default: break;
            }
            return enumInfos.ToArray();
        }
        public static StructureInfo[] GetStructureChildInfo(MetaName name)
        {
            var structureInfos = new List<StructureInfo>();

            switch (name)
            {
                case MetaName.CMapTypes:
                    {
                        break;
                    }
                case MetaName.CBaseArchetypeDef:
                    {
                        break;
                    }
                case MetaName.rage__fwInstancedMapData:
                    {
                        break;
                    }
                case MetaName.CLODLight:
                    {
                        break;
                    }
                case MetaName.CDistantLODLight:
                    {
                        break;
                    }
                case MetaName.CBlockDesc:
                    {
                        break;
                    }
                case MetaName.CMapData:
                    {
                        structureInfos.Add(MetaInfo.GetStructureInfo(MetaName.rage__fwInstancedMapData));
                        structureInfos.Add(MetaInfo.GetStructureInfo(MetaName.CLODLight));
                        structureInfos.Add(MetaInfo.GetStructureInfo(MetaName.CDistantLODLight));
                        structureInfos.Add(MetaInfo.GetStructureInfo(MetaName.CBlockDesc));
                        break;
                    }
                case MetaName.CEntityDef:
                    {
                        break;
                    }
                case MetaName.CTimeCycleModifier:
                    {
                        break;
                    }
                case MetaName.CTimeArchetypeDef:
                    {
                        break;
                    }
                case MetaName.CExtensionDefLightEffect:
                    {
                        break;
                    }
                case MetaName.CLightAttrDef:
                    {
                        break;
                    }
                case MetaName.CMloInstanceDef:
                    {
                        break;
                    }
                case (MetaName)(975711773):
                    {
                        break;
                    }
                case (MetaName)(-1553183059):
                    {
                        break;
                    }
                case MetaName.CMloArchetypeDef:
                    {
                        break;
                    }
                case MetaName.CMloRoomDef:
                    {
                        break;
                    }
                case MetaName.CMloPortalDef:
                    {
                        break;
                    }
                case MetaName.CMloTimeCycleModifier:
                    {
                        break;
                    }
                case MetaName.CExtensionDefParticleEffect:
                    {
                        break;
                    }
                case MetaName.CCompositeEntityType:
                    {
                        break;
                    }
                case (MetaName)(1980345114):
                    {
                        break;
                    }
                case (MetaName)(-864638612):
                    {
                        break;
                    }
                case MetaName.CExtensionDefAudioCollisionSettings:
                    {
                        break;
                    }
                case MetaName.CExtensionDefSpawnPoint:
                    {
                        break;
                    }
                case MetaName.CExtensionDefAudioEmitter:
                    {
                        break;
                    }
                case MetaName.CExtensionDefExplosionEffect:
                    {
                        break;
                    }
                case MetaName.CExtensionDefLadder:
                    {
                        break;
                    }
                case MetaName.CExtensionDefBuoyancy:
                    {
                        break;
                    }
                case MetaName.CExtensionDefExpression:
                    {
                        break;
                    }
                case MetaName.CExtensionDefLightShaft:
                    {
                        break;
                    }
                case (MetaName)(-489959468):
                    {
                        break;
                    }
                case MetaName.CExtensionDefDoor:
                    {
                        break;
                    }
                case MetaName.CMloEntitySet:
                    {
                        break;
                    }
                case MetaName.CExtensionDefSpawnPointOverride:
                    {
                        break;
                    }
                case MetaName.CExtensionDefWindDisturbance:
                    {
                        break;
                    }
                case MetaName.CCarGen:
                    {
                        break;
                    }
                case MetaName.rage__spdAABB:
                    {
                        break;
                    }
                case MetaName.rage__fwGrassInstanceListDef:
                    {
                        structureInfos.Add(MetaInfo.GetStructureInfo(MetaName.rage__spdAABB));
                        break;
                    }
                case MetaName.rage__fwGrassInstanceListDef__InstanceData:
                    {
                        break;
                    }
                case MetaName.CExtensionDefProcObject:
                    {
                        break;
                    }
                case MetaName.rage__phVerletClothCustomBounds:
                    {
                        break;
                    }
                case (MetaName)(1701774085):
                    {
                        break;
                    }
                default: break;
            }
            return structureInfos.ToArray();
        }
    }

    // Enums

    public enum Unk_1991964615 // Key : 1866031916
    {
        ASSET_TYPE_UNINITIALIZED = 0,
        ASSET_TYPE_FRAGMENT = 1,
        ASSET_TYPE_DRAWABLE = 2,
        ASSET_TYPE_DRAWABLEDICTIONARY = 3,
        ASSET_TYPE_ASSETLESS = 4,
    }

    public enum Unk_1264241711 // Key : 1856311430
    {
        LODTYPES_DEPTH_HD = 0,
        LODTYPES_DEPTH_LOD = 1,
        LODTYPES_DEPTH_SLOD1 = 2,
        LODTYPES_DEPTH_SLOD2 = 3,
        LODTYPES_DEPTH_SLOD3 = 4,
        LODTYPES_DEPTH_ORPHANHD = 5,
        LODTYPES_DEPTH_SLOD4 = 6,
    }

    public enum Unk_648413703 // Key : -2094609585
    {
        PRI_REQUIRED = 0,
        PRI_OPTIONAL_HIGH = 1,
        PRI_OPTIONAL_MEDIUM = 2,
        PRI_OPTIONAL_LOW = 3,
    }

    public enum Unk_3573596290 // Key : 671739257
    {
        kBoth = 0,
        Unk_4171042740 = 1,
        Unk_549935372 = 2,
    }

    public enum Unk_700327466 // Key : -1480371201
    {
        IgnoreMaxInRange = 0,
        NoSpawn = 1,
        StationaryReactions = 2,
        Unk_3257836369 = 3,
        Unk_2165609255 = 4,
        ActivateVehicleSiren = 5,
        AggressiveVehicleDriving = 6,
        Unk_2004780781 = 7,
        Unk_536864854 = 8,
        Unk_3441065168 = 9,
        AerialVehiclePoint = 10,
        Unk_763077056 = 11,
        Unk_3690227693 = 12,
        Unk_1601179199 = 13,
        Unk_2583152330 = 14,
        Unk_3490317520 = 15,
        InWater = 16,
        Unk_1269249358 = 17,
        OpenDoor = 18,
        PreciseUseTime = 19,
        Unk_2247631388 = 20,
        Unk_4100708934 = 21,
        ExtendedRange = 22,
        ShortRange = 23,
        HighPriority = 24,
        IgnoreLoitering = 25,
        UseSearchlight = 26,
        ResetNoCollisionOnCleanUp = 27,
        Unk_3304563391 = 28,
        Unk_1111379709 = 29,
        IgnoreWeatherRestrictions = 30,
    }

    public enum Unk_1294270217 // Key : -780397138
    {
        METAL_SOLID_LADDER = 0,
        METAL_LIGHT_LADDER = 1,
        Unk_3202617440 = 2,
    }

    public enum Unk_1931949281 // Key : -755366114
    {
        Unk_676250331 = 0,
        Unk_2399586564 = 1,
        Unk_2057886646 = 2,
        Unk_1816804348 = 3,
        Unk_152140774 = 4,
        Unk_2088805984 = 5,
        Unk_1098824079 = 6,
        Unk_1492299290 = 7,
    }

    public enum Unk_2266515059 // Key : -7494951
    {
        Unk_665241531 = 0,
        Unk_462992848 = 1,
    }

    public enum Unk_3044470860 // Key : 1585854303
    {
        Unk_997866013 = 0,
    }


    // Structures

    [StructLayout(LayoutKind.Sequential)]
    public struct CMapTypes // 80 bytes, Key:2608875220
    {
        public long Unused0; // 0
        public Array_StructurePointer extensions; // 8  Key: 0
        public Array_StructurePointer archetypes; // 24  Key: 0
        public uint name; // 40  Key: 0
        public Array_uint dependencies; // 48  Key: 0
        public Array_Structure compositeEntityTypes; // 64  Key: CCompositeEntityType
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CBaseArchetypeDef // 144 bytes, Key:2411387556
    {
        public long Unused0; // 0
        public float lodDist; // 8  Key: 0
        public uint flags; // 12  Key: 0
        public uint specialAttribute; // 16  Key: 0
        public uint Unused1; // 20
        public long Unused2; // 24
        public Vector3 bbMin; // 32  Key: 0
        public uint Unused3; // 44
        public Vector3 bbMax; // 48  Key: 0
        public uint Unused4; // 60
        public Vector3 bsCentre; // 64  Key: 0
        public uint Unused5; // 76
        public float bsRadius; // 80  Key: 0
        public float hdTextureDist; // 84  Key: 0
        public uint name; // 88  Key: 0
        public uint textureDictionary; // 92  Key: 0
        public uint clipDictionary; // 96  Key: 0
        public uint drawableDictionary; // 100  Key: 0
        public uint physicsDictionary; // 104  Key: 0
        public Unk_1991964615 assetType; // 108  Key: 1991964615
        public uint assetName; // 112  Key: 0
        public uint Unused6; // 116
        public Array_StructurePointer extensions; // 120  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct rage__fwInstancedMapData // 48 bytes, Key:1836780118
    {
        public long Unused0; // 0
        public uint ImapLink; // 8  Key: 0
        public uint Unused1; // 12
        public Array_Structure PropInstanceList; // 16  Key: rage__fwPropInstanceListDef
        public Array_Structure GrassInstanceList; // 32  Key: rage__fwGrassInstanceListDef
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CLODLight // 136 bytes, Key:2325189228
    {
        public long Unused0; // 0
        public Array_Structure direction; // 8  Key: VECTOR3
        public Array_float falloff; // 24  Key: 0
        public Array_float falloffExponent; // 40  Key: 0
        public Array_uint timeAndStateFlags; // 56  Key: 0
        public Array_uint hash; // 72  Key: 0
        public Array_byte coneInnerAngle; // 88  Key: 0
        public Array_byte coneOuterAngleOrCapExt; // 104  Key: 0
        public Array_byte coronaIntensity; // 120  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CDistantLODLight // 48 bytes, Key:2820908419
    {
        public long Unused0; // 0
        public Array_Structure position; // 8  Key: VECTOR3
        public Array_uint RGBI; // 24  Key: 0
        public ushort numStreetLights; // 40  Key: 0
        public ushort category; // 42  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CBlockDesc // 72 bytes, Key:2015795449
    {
        public uint version; // 0  Key: 0
        public uint flags; // 4  Key: 0
        public CharPointer name; // 8  Key: 0
        public CharPointer exportedBy; // 24  Key: 0
        public CharPointer owner; // 40  Key: 0
        public CharPointer time; // 56  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CMapData // 512 bytes, Key:3448101671
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint parent; // 12  Key: 0
        public uint flags; // 16  Key: 0
        public uint contentFlags; // 20  Key: 0
        public long Unused1; // 24
        public Vector3 streamingExtentsMin; // 32  Key: 0
        public uint Unused2; // 44
        public Vector3 streamingExtentsMax; // 48  Key: 0
        public uint Unused3; // 60
        public Vector3 entitiesExtentsMin; // 64  Key: 0
        public uint Unused4; // 76
        public Vector3 entitiesExtentsMax; // 80  Key: 0
        public uint Unused5; // 92
        public Array_StructurePointer entities; // 96  Key: 0
        public Array_Structure containerLods; // 112  Key: 372253349
        public Array_Structure boxOccluders; // 128  Key: 975711773
        public Array_Structure occludeModels; // 144  Key: 2741784237
        public Array_uint physicsDictionaries; // 160  Key: 0
        public rage__fwInstancedMapData instancedData; // 176  Key: rage__fwInstancedMapData
        public Array_Structure timeCycleModifiers; // 224  Key: CTimeCycleModifier
        public Array_Structure carGenerators; // 240  Key: CCarGen
        public CLODLight LODLightsSOA; // 256  Key: CLODLight
        public CDistantLODLight DistantLODLightsSOA; // 392  Key: CDistantLODLight
        public CBlockDesc block; // 440  Key: CBlockDesc
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CEntityDef // 128 bytes, Key:1825799514
    {
        public long Unused0; // 0
        public uint archetypeName; // 8  Key: 0
        public uint flags; // 12  Key: 0
        public uint guid; // 16  Key: 0
        public uint Unused1; // 20
        public long Unused2; // 24
        public Vector3 position; // 32  Key: 0
        public uint Unused3; // 44
        public Vector4 rotation; // 48  Key: 0
        public float scaleXY; // 64  Key: 0
        public float scaleZ; // 68  Key: 0
        public int parentIndex; // 72  Key: 0
        public float lodDist; // 76  Key: 0
        public float childLodDist; // 80  Key: 0
        public Unk_1264241711 lodLevel; // 84  Key: 1264241711
        public uint numChildren; // 88  Key: 0
        public Unk_648413703 priorityLevel; // 92  Key: 648413703
        public Array_StructurePointer extensions; // 96  Key: 0
        public int ambientOcclusionMultiplier; // 112  Key: 0
        public int artificialAmbientOcclusion; // 116  Key: 0
        public uint tintValue; // 120  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CTimeCycleModifier // 64 bytes, Key:2683420777
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 minExtents; // 16  Key: 0
        public uint Unused2; // 28
        public Vector3 maxExtents; // 32  Key: 0
        public uint Unused3; // 44
        public float percentage; // 48  Key: 0
        public float range; // 52  Key: 0
        public uint startHour; // 56  Key: 0
        public uint endHour; // 60  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CTimeArchetypeDef // 160 bytes, Key:2520619910
    {
        public long Unused0; // 0
        public float lodDist; // 8  Key: 0
        public uint flags; // 12  Key: 0
        public uint specialAttribute; // 16  Key: 0
        public uint Unused1; // 20
        public long Unused2; // 24
        public Vector3 bbMin; // 32  Key: 0
        public uint Unused3; // 44
        public Vector3 bbMax; // 48  Key: 0
        public uint Unused4; // 60
        public Vector3 bsCentre; // 64  Key: 0
        public uint Unused5; // 76
        public float bsRadius; // 80  Key: 0
        public float hdTextureDist; // 84  Key: 0
        public uint name; // 88  Key: 0
        public uint textureDictionary; // 92  Key: 0
        public uint clipDictionary; // 96  Key: 0
        public uint drawableDictionary; // 100  Key: 0
        public uint physicsDictionary; // 104  Key: 0
        public Unk_1991964615 assetType; // 108  Key: 1991964615
        public uint assetName; // 112  Key: 0
        public uint Unused6; // 116
        public Array_StructurePointer extensions; // 120  Key: 0
        public long Unused7; // 136
        public uint timeFlags; // 144  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefLightEffect // 48 bytes, Key:2436199897
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public Array_Structure instances; // 32  Key: CLightAttrDef
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CLightAttrDef // 160 bytes, Key:2363260268
    {
        public uint Unused0; // 4
        public ArrayOfBytes3 posn; // 8  Key: 3
        public ArrayOfBytes3 colour; // 20  Key: 3
        public byte flashiness; // 23  Key: 0
        public float intensity; // 24  Key: 0
        public uint flags; // 28  Key: 0
        public short boneTag; // 32  Key: 0
        public byte lightType; // 34  Key: 0
        public byte groupId; // 35  Key: 0
        public uint timeFlags; // 36  Key: 0
        public float falloff; // 40  Key: 0
        public float falloffExponent; // 44  Key: 0
        public ArrayOfBytes4 cullingPlane; // 48  Key: 4
        public byte shadowBlur; // 64  Key: 0
        public byte padding1; // 65  Key: 0
        public short padding2; // 66  Key: 0
        public uint padding3; // 68  Key: 0
        public float volIntensity; // 72  Key: 0
        public float volSizeScale; // 76  Key: 0
        public ArrayOfBytes3 volOuterColour; // 80  Key: 3
        public byte lightHash; // 83  Key: 0
        public float volOuterIntensity; // 84  Key: 0
        public float coronaSize; // 88  Key: 0
        public float volOuterExponent; // 92  Key: 0
        public byte lightFadeDistance; // 96  Key: 0
        public byte shadowFadeDistance; // 97  Key: 0
        public byte specularFadeDistance; // 98  Key: 0
        public byte volumetricFadeDistance; // 99  Key: 0
        public float shadowNearClip; // 100  Key: 0
        public float coronaIntensity; // 104  Key: 0
        public float coronaZBias; // 108  Key: 0
        public ArrayOfBytes3 direction; // 112  Key: 3
        public ArrayOfBytes3 tangent; // 124  Key: 3
        public float coneInnerAngle; // 136  Key: 0
        public float coneOuterAngle; // 140  Key: 0
        public ArrayOfBytes3 extents; // 144  Key: 3
        public uint projectedTextureKey; // 156  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CMloInstanceDef // 160 bytes, Key:2151576752
    {
        public long Unused0; // 0
        public uint archetypeName; // 8  Key: 0
        public uint flags; // 12  Key: 0
        public uint guid; // 16  Key: 0
        public uint Unused1; // 20
        public long Unused2; // 24
        public Vector3 position; // 32  Key: 0
        public uint Unused3; // 44
        public Vector4 rotation; // 48  Key: 0
        public float scaleXY; // 64  Key: 0
        public float scaleZ; // 68  Key: 0
        public int parentIndex; // 72  Key: 0
        public float lodDist; // 76  Key: 0
        public float childLodDist; // 80  Key: 0
        public Unk_1264241711 lodLevel; // 84  Key: 1264241711
        public uint numChildren; // 88  Key: 0
        public Unk_648413703 priorityLevel; // 92  Key: 648413703
        public Array_StructurePointer extensions; // 96  Key: 0
        public int ambientOcclusionMultiplier; // 112  Key: 0
        public int artificialAmbientOcclusion; // 116  Key: 0
        public uint tintValue; // 120  Key: 0
        public uint Unused4; // 124
        public uint groupId; // 128  Key: 0
        public uint floorId; // 132  Key: 0
        public Array_uint defaultEntitySets; // 136  Key: 0
        public uint numExitPortals; // 152  Key: 0
        public uint MLOInstflags; // 156  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Unk_975711773 // 16 bytes, Key:1831736438
    {
        public short iCenterX; // 0  Key: 0
        public short iCenterY; // 2  Key: 0
        public short iCenterZ; // 4  Key: 0
        public short iCosZ; // 6  Key: 0
        public short iLength; // 8  Key: 0
        public short iWidth; // 10  Key: 0
        public short iHeight; // 12  Key: 0
        public short iSinZ; // 14  Key: 0
        public long Unused0; // 16
        public long Unused1; // 24
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Unk_2741784237 // 64 bytes, Key:1172796107
    {
        public Vector3 bmin; // 0  Key: 0
        public uint Unused0; // 12
        public Vector3 bmax; // 16  Key: 0
        public uint Unused1; // 28
        public uint dataSize; // 32  Key: 0
        public byte Unused2; // 37
        public short Unused3; // 38
        public DataBlockPointer verts; // 40  Key: 2
        public ushort Unk_853977995; // 48  Key: 0
        public ushort Unk_2337695078; // 50  Key: 0
        public uint flags; // 52  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CMloArchetypeDef // 240 bytes, Key:937664754
    {
        public long Unused0; // 0
        public float lodDist; // 8  Key: 0
        public uint flags; // 12  Key: 0
        public uint specialAttribute; // 16  Key: 0
        public uint Unused1; // 20
        public long Unused2; // 24
        public Vector3 bbMin; // 32  Key: 0
        public uint Unused3; // 44
        public Vector3 bbMax; // 48  Key: 0
        public uint Unused4; // 60
        public Vector3 bsCentre; // 64  Key: 0
        public uint Unused5; // 76
        public float bsRadius; // 80  Key: 0
        public float hdTextureDist; // 84  Key: 0
        public uint name; // 88  Key: 0
        public uint textureDictionary; // 92  Key: 0
        public uint clipDictionary; // 96  Key: 0
        public uint drawableDictionary; // 100  Key: 0
        public uint physicsDictionary; // 104  Key: 0
        public Unk_1991964615 assetType; // 108  Key: 1991964615
        public uint assetName; // 112  Key: 0
        public uint Unused6; // 116
        public Array_StructurePointer extensions; // 120  Key: 0
        public long Unused7; // 136
        public uint mloFlags; // 144  Key: 0
        public uint Unused8; // 148
        public Array_StructurePointer entities; // 152  Key: 0
        public Array_Structure rooms; // 168  Key: CMloRoomDef
        public Array_Structure portals; // 184  Key: CMloPortalDef
        public Array_Structure entitySets; // 200  Key: CMloEntitySet
        public Array_Structure timeCycleModifiers; // 216  Key: CMloTimeCycleModifier
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CMloRoomDef // 112 bytes, Key:3885428245
    {
        public long Unused0; // 0
        public CharPointer name; // 8  Key: 0
        public long Unused1; // 24
        public Vector3 bbMin; // 32  Key: 0
        public uint Unused2; // 44
        public Vector3 bbMax; // 48  Key: 0
        public uint Unused3; // 60
        public float blend; // 64  Key: 0
        public uint timecycleName; // 68  Key: 0
        public uint secondaryTimecycleName; // 72  Key: 0
        public uint flags; // 76  Key: 0
        public uint portalCount; // 80  Key: 0
        public int floorId; // 84  Key: 0
        public int exteriorVisibiltyDepth; // 88  Key: 0
        public Array_uint Unk_2382704940; // 96  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CMloPortalDef // 64 bytes, Key:1110221513
    {
        public long Unused0; // 0
        public uint roomFrom; // 8  Key: 0
        public uint roomTo; // 12  Key: 0
        public uint flags; // 16  Key: 0
        public uint mirrorPriority; // 20  Key: 0
        public uint opacity; // 24  Key: 0
        public uint audioOcclusion; // 28  Key: 0
        public Array_Vector3 corners; // 32  Key: 0
        public Array_uint Unk_2382704940; // 48  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CMloTimeCycleModifier // 48 bytes, Key:838874674
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector4 sphere; // 16  Key: 0
        public float percentage; // 32  Key: 0
        public float range; // 36  Key: 0
        public uint startHour; // 40  Key: 0
        public uint endHour; // 44  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefParticleEffect // 96 bytes, Key:466596385
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public Vector4 offsetRotation; // 32  Key: 0
        public CharPointer fxName; // 48  Key: 0
        public int fxType; // 64  Key: 0
        public int boneTag; // 68  Key: 0
        public float scale; // 72  Key: 0
        public int probability; // 76  Key: 0
        public int flags; // 80  Key: 0
        public uint color; // 84  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CCompositeEntityType // 304 bytes, Key:659539004
    {
        public ArrayOfChars64 Name; // 0  Key: 64
        public float lodDist; // 64  Key: 0
        public uint flags; // 68  Key: 0
        public uint specialAttribute; // 72  Key: 0
        public uint Unused0; // 76
        public Vector3 bbMin; // 80  Key: 0
        public uint Unused1; // 92
        public Vector3 bbMax; // 96  Key: 0
        public uint Unused2; // 108
        public Vector3 bsCentre; // 112  Key: 0
        public uint Unused3; // 124
        public float bsRadius; // 128  Key: 0
        public uint Unused4; // 132
        public ArrayOfChars64 StartModel; // 136  Key: 64
        public ArrayOfChars64 EndModel; // 200  Key: 64
        public uint StartImapFile; // 264  Key: 0
        public uint EndImapFile; // 268  Key: 0
        public uint PtFxAssetName; // 272  Key: 0
        public uint Unused5; // 276
        public Array_Structure Animations; // 280  Key: 1980345114
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Unk_1980345114 // 216 bytes, Key:4110496011
    {
        public ArrayOfChars64 AnimDict; // 0  Key: 64
        public ArrayOfChars64 AnimName; // 64  Key: 64
        public ArrayOfChars64 AnimatedModel; // 128  Key: 64
        public float punchInPhase; // 192  Key: 0
        public float punchOutPhase; // 196  Key: 0
        public Array_Structure effectsData; // 200  Key: 3430328684
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Unk_3430328684 // 160 bytes, Key:1724963966
    {
        public uint fxType; // 0  Key: 0
        public uint Unused0; // 4
        public long Unused1; // 8
        public Vector3 fxOffsetPos; // 16  Key: 0
        public uint Unused2; // 28
        public Vector4 fxOffsetRot; // 32  Key: 0
        public uint boneTag; // 48  Key: 0
        public float startPhase; // 52  Key: 0
        public float endPhase; // 56  Key: 0
        public bool ptFxIsTriggered; // 60  Key: 0
        public ArrayOfChars64 ptFxTag; // 61  Key: 64
        public byte Unused3; // 125
        public short Unused4; // 126
        public float ptFxScale; // 128  Key: 0
        public float ptFxProbability; // 132  Key: 0
        public bool ptFxHasTint; // 136  Key: 0
        public byte ptFxTintR; // 137  Key: 0
        public byte ptFxTintG; // 138  Key: 0
        public byte ptFxTintB; // 139  Key: 0
        public uint Unused5; // 140
        public Vector3 ptFxSize; // 144  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefAudioCollisionSettings // 48 bytes, Key:2701897500
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public uint settings; // 32  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefSpawnPoint // 96 bytes, Key:3077340721
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public Vector4 offsetRotation; // 32  Key: 0
        public uint spawnType; // 48  Key: 0
        public uint pedType; // 52  Key: 0
        public uint group; // 56  Key: 0
        public uint interior; // 60  Key: 0
        public uint requiredImap; // 64  Key: 0
        public Unk_3573596290 availableInMpSp; // 68  Key: 3573596290
        public float probability; // 72  Key: 0
        public float timeTillPedLeaves; // 76  Key: 0
        public float radius; // 80  Key: 0
        public byte start; // 84  Key: 0
        public byte end; // 85  Key: 0
        public short Unused3; // 86
        public Unk_700327466 flags; // 88  Key: 700327466
        public bool highPri; // 92  Key: 0
        public bool extendedRange; // 93  Key: 0
        public bool shortRange; // 94  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefAudioEmitter // 64 bytes, Key:15929839
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public Vector4 offsetRotation; // 32  Key: 0
        public uint effectHash; // 48  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefExplosionEffect // 80 bytes, Key:2840366784
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public Vector4 offsetRotation; // 32  Key: 0
        public CharPointer explosionName; // 48  Key: 0
        public int boneTag; // 64  Key: 0
        public int explosionTag; // 68  Key: 0
        public int explosionType; // 72  Key: 0
        public uint flags; // 76  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefLadder // 96 bytes, Key:1978210597
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public Vector3 bottom; // 32  Key: 0
        public uint Unused3; // 44
        public Vector3 top; // 48  Key: 0
        public uint Unused4; // 60
        public Vector3 normal; // 64  Key: 0
        public uint Unused5; // 76
        public Unk_1294270217 materialType; // 80  Key: 1294270217
        public uint template; // 84  Key: 0
        public bool canGetOffAtTop; // 88  Key: 0
        public bool canGetOffAtBottom; // 89  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefBuoyancy // 32 bytes, Key:2383039928
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefExpression // 48 bytes, Key:24441706
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public uint Unk_1095612811; // 32  Key: 0
        public uint expressionName; // 36  Key: 0
        public uint Unk_2766477159; // 40  Key: 0
        public bool Unk_1562817888; // 44  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefLightShaft // 176 bytes, Key:2526429398
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public Vector3 cornerA; // 32  Key: 0
        public uint Unused3; // 44
        public Vector3 cornerB; // 48  Key: 0
        public uint Unused4; // 60
        public Vector3 cornerC; // 64  Key: 0
        public uint Unused5; // 76
        public Vector3 cornerD; // 80  Key: 0
        public uint Unused6; // 92
        public Vector3 direction; // 96  Key: 0
        public uint Unused7; // 108
        public float directionAmount; // 112  Key: 0
        public float length; // 116  Key: 0
        public float Unk_1616789093; // 120  Key: 0
        public float Unk_120454521; // 124  Key: 0
        public float Unk_1297365553; // 128  Key: 0
        public float Unk_75548206; // 132  Key: 0
        public float Unk_40301253; // 136  Key: 0
        public float Unk_475013030; // 140  Key: 0
        public uint color; // 144  Key: 0
        public float intensity; // 148  Key: 0
        public byte flashiness; // 152  Key: 0
        public byte Unused8; // 153
        public short Unused9; // 154
        public uint flags; // 156  Key: 0
        public Unk_1931949281 densityType; // 160  Key: 1931949281
        public Unk_2266515059 volumeType; // 164  Key: 2266515059
        public float softness; // 168  Key: 0
        public bool Unk_59101696; // 172  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct VECTOR3 // 12 bytes, Key:2751397072
    {
        public float x; // 0  Key: 0
        public float y; // 4  Key: 0
        public float z; // 8  Key: 0
        public uint Unused0; // 12
        public long Unused1; // 16
        public long Unused2; // 24
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CBaseArchetypeDef_c2 // 128 bytes, Key:2352343492
    {
        public long Unused0; // 0
        public float lodDist; // 8  Key: 0
        public uint flags; // 12  Key: 0
        public uint specialAttribute; // 16  Key: 0
        public uint Unused1; // 20
        public long Unused2; // 24
        public Vector3 bbMin; // 32  Key: 0
        public uint Unused3; // 44
        public Vector3 bbMax; // 48  Key: 0
        public uint Unused4; // 60
        public Vector3 bsCentre; // 64  Key: 0
        public uint Unused5; // 76
        public float bsRadius; // 80  Key: 0
        public float hdTextureDist; // 84  Key: 0
        public uint name; // 88  Key: 0
        public uint textureDictionary; // 92  Key: 0
        public uint clipDictionary; // 96  Key: 0
        public uint drawableDictionary; // 100  Key: 0
        public uint physicsDictionary; // 104  Key: 0
        public uint Unused6; // 108
        public Array_StructurePointer extensions; // 112  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefDoor // 48 bytes, Key:2671601385
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public bool enableLimitAngle; // 32  Key: 0
        public bool startsLocked; // 33  Key: 0
        public bool canBreak; // 34  Key: 0
        public byte Unused3; // 35
        public float limitAngle; // 36  Key: 0
        public float doorTargetRatio; // 40  Key: 0
        public uint audioHash; // 44  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CMloEntitySet // 48 bytes, Key:4180211587
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public Array_uint locations; // 16  Key: 0
        public Array_StructurePointer entities; // 32  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefSpawnPointOverride // 64 bytes, Key:2551875873
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public uint ScenarioType; // 32  Key: 0
        public byte iTimeStartOverride; // 36  Key: 0
        public byte iTimeEndOverride; // 37  Key: 0
        public short Unused3; // 38
        public uint Group; // 40  Key: 0
        public uint ModelSet; // 44  Key: 0
        public Unk_3573596290 AvailabilityInMpSp; // 48  Key: 3573596290
        public Unk_700327466 Flags; // 52  Key: 700327466
        public float Radius; // 56  Key: 0
        public float TimeTillPedLeaves; // 60  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefWindDisturbance // 96 bytes, Key:3971538917
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public Vector4 offsetRotation; // 32  Key: 0
        public int disturbanceType; // 48  Key: 0
        public int boneTag; // 52  Key: 0
        public long Unused3; // 56
        public Vector4 size; // 64  Key: 0
        public float strength; // 80  Key: 0
        public int flags; // 84  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CCarGen // 80 bytes, Key:2345238261
    {
        public long Unused0; // 0
        public long Unused1; // 8
        public Vector3 position; // 16  Key: 0
        public uint Unused2; // 28
        public float orientX; // 32  Key: 0
        public float orientY; // 36  Key: 0
        public float perpendicularLength; // 40  Key: 0
        public uint carModel; // 44  Key: 0
        public uint flags; // 48  Key: 0
        public int bodyColorRemap1; // 52  Key: 0
        public int bodyColorRemap2; // 56  Key: 0
        public int bodyColorRemap3; // 60  Key: 0
        public int bodyColorRemap4; // 64  Key: 0
        public uint popGroup; // 68  Key: 0
        public sbyte livery; // 72  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct rage__spdAABB // 32 bytes, Key:1158138379
    {
        public Vector4 min; // 0  Key: 0
        public Vector4 max; // 16  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct rage__fwGrassInstanceListDef // 96 bytes, Key:941808164
    {
        public rage__spdAABB BatchAABB; // 0  Key: rage__spdAABB
        public Vector3 ScaleRange; // 32  Key: 0
        public uint Unused0; // 44
        public uint archetypeName; // 48  Key: 0
        public uint lodDist; // 52  Key: 0
        public float LodFadeStartDist; // 56  Key: 0
        public float LodInstFadeRange; // 60  Key: 0
        public float OrientToTerrain; // 64  Key: 0
        public uint Unused1; // 68
        public Array_Structure InstanceList; // 72  Key: rage__fwGrassInstanceListDef__InstanceData
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct rage__fwGrassInstanceListDef__InstanceData // 16 bytes, Key:2740378365
    {
        public ArrayOfBytes3 Position; // 0  Key: 3
        public byte NormalX; // 6  Key: 0
        public byte NormalY; // 7  Key: 0
        public ArrayOfBytes3 Color; // 8  Key: 3
        public byte Scale; // 11  Key: 0
        public byte Ao; // 12  Key: 0
        public ArrayOfBytes3 Pad; // 13  Key: 3
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CExtensionDefProcObject // 80 bytes, Key:3965391891
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Vector3 offsetPosition; // 16  Key: 0
        public uint Unused2; // 28
        public float radiusInner; // 32  Key: 0
        public float radiusOuter; // 36  Key: 0
        public float spacing; // 40  Key: 0
        public float minScale; // 44  Key: 0
        public float maxScale; // 48  Key: 0
        public float Unk_3913056845; // 52  Key: 0
        public float Unk_147400493; // 56  Key: 0
        public float Unk_2591582364; // 60  Key: 0
        public float Unk_3889902555; // 64  Key: 0
        public uint objectHash; // 68  Key: 0
        public uint flags; // 72  Key: 0
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct rage__phVerletClothCustomBounds // 32 bytes, Key:2075461750
    {
        public long Unused0; // 0
        public uint name; // 8  Key: 0
        public uint Unused1; // 12
        public Array_Structure CollisionData; // 16  Key: 1701774085
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Unk_1701774085 // 96 bytes, Key:2859775340
    {
        public CharPointer OwnerName; // 0  Key: 0
        public Vector4 Rotation; // 16  Key: 0
        public Vector3 Position; // 32  Key: 0
        public uint Unused0; // 44
        public Vector3 Normal; // 48  Key: 0
        public uint Unused1; // 60
        public float CapsuleRadius; // 64  Key: 0
        public float CapsuleLen; // 68  Key: 0
        public float CapsuleHalfHeight; // 72  Key: 0
        public float CapsuleHalfWidth; // 76  Key: 0
        public Unk_3044470860 Flags; // 80  Key: 3044470860
    }




}
