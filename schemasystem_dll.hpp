#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace schemas {
        namespace schemasystem_dll {
            namespace ResourceId_t {
                inline constexpr std::ptrdiff_t m_Value = 0x0;
            }
            namespace CExampleSchemaVData_Monomorphic {
                inline constexpr std::ptrdiff_t m_nExample1 = 0x0;
                inline constexpr std::ptrdiff_t m_nExample2 = 0x4;
            }
            namespace CSchemaSystemInternalRegistration {
                inline constexpr std::ptrdiff_t m_KV3 = 0x168;
                inline constexpr std::ptrdiff_t m_Color = 0xE0;
                inline constexpr std::ptrdiff_t m_QAngle = 0x40;
                inline constexpr std::ptrdiff_t m_Vector = 0x8;
                inline constexpr std::ptrdiff_t m_Vector2D = 0x0;
                inline constexpr std::ptrdiff_t m_Vector4D = 0xE4;
                inline constexpr std::ptrdiff_t m_VectorWS = 0x14;
                inline constexpr std::ptrdiff_t m_CTransform = 0x100;
                inline constexpr std::ptrdiff_t m_CUtlString = 0x138;
                inline constexpr std::ptrdiff_t m_CUtlSymbol = 0x140;
                inline constexpr std::ptrdiff_t m_Quaternion = 0x30;
                inline constexpr std::ptrdiff_t m_pKeyValues = 0x120;
                inline constexpr std::ptrdiff_t m_DegreeEuler = 0x64;
                inline constexpr std::ptrdiff_t m_RadianEuler = 0x58;
                inline constexpr std::ptrdiff_t m_matrix3x4_t = 0x80;
                inline constexpr std::ptrdiff_t m_stringToken = 0x144;
                inline constexpr std::ptrdiff_t m_matrix3x4a_t = 0xB0;
                inline constexpr std::ptrdiff_t m_ResourceTypes = 0x160;
                inline constexpr std::ptrdiff_t m_VectorAligned = 0x20;
                inline constexpr std::ptrdiff_t m_RotationVector = 0x4C;
                inline constexpr std::ptrdiff_t m_CUtlBinaryBlock = 0x128;
                inline constexpr std::ptrdiff_t m_QuaternionStorage = 0x70;
                inline constexpr std::ptrdiff_t m_stringTokenWithStorage = 0x148;
            }
            namespace CExampleSchemaVData_PolymorphicBase {
                inline constexpr std::ptrdiff_t m_nBase = 0x8;
            }
            namespace CExampleSchemaVData_PolymorphicDerivedA {
                inline constexpr std::ptrdiff_t m_nDerivedA = 0x10;
            }
            namespace CExampleSchemaVData_PolymorphicDerivedB {
                inline constexpr std::ptrdiff_t m_nDerivedB = 0x10;
            }
            namespace InfoForResourceTypeCResourceManifestInternal {

            }
            namespace fieldtype_t {
                inline constexpr std::ptrdiff_t FIELD_SHIM = 0x3F;
                inline constexpr std::ptrdiff_t FIELD_TICK = 0x10;
                inline constexpr std::ptrdiff_t FIELD_TIME = 0xF;
                inline constexpr std::ptrdiff_t FIELD_VOID = 0x0;
                inline constexpr std::ptrdiff_t FIELD_INPUT = 0x12;
                inline constexpr std::ptrdiff_t FIELD_INT16 = 0x7;
                inline constexpr std::ptrdiff_t FIELD_INT32 = 0x5;
                inline constexpr std::ptrdiff_t FIELD_INT64 = 0x1A;
                inline constexpr std::ptrdiff_t FIELD_UINT8 = 0x39;
                inline constexpr std::ptrdiff_t FIELD_CUSTOM = 0xB;
                inline constexpr std::ptrdiff_t FIELD_HMODEL = 0x2A;
                inline constexpr std::ptrdiff_t FIELD_HVDATA = 0x49;
                inline constexpr std::ptrdiff_t FIELD_QANGLE = 0x27;
                inline constexpr std::ptrdiff_t FIELD_STRING = 0x2;
                inline constexpr std::ptrdiff_t FIELD_UINT16 = 0x3A;
                inline constexpr std::ptrdiff_t FIELD_UINT32 = 0x25;
                inline constexpr std::ptrdiff_t FIELD_UINT64 = 0x21;
                inline constexpr std::ptrdiff_t FIELD_UNUSED = 0x18;
                inline constexpr std::ptrdiff_t FIELD_VECTOR = 0x3;
                inline constexpr std::ptrdiff_t FIELD_BOOLEAN = 0x6;
                inline constexpr std::ptrdiff_t FIELD_COLOR32 = 0x9;
                inline constexpr std::ptrdiff_t FIELD_CSTRING = 0x1E;
                inline constexpr std::ptrdiff_t FIELD_EHANDLE = 0xD;
                inline constexpr std::ptrdiff_t FIELD_FLOAT32 = 0x1;
                inline constexpr std::ptrdiff_t FIELD_FLOAT64 = 0x22;
                inline constexpr std::ptrdiff_t FIELD_HSCRIPT = 0x1F;
                inline constexpr std::ptrdiff_t FIELD_SCALE32 = 0x4A;
                inline constexpr std::ptrdiff_t FIELD_VARIANT = 0x20;
                inline constexpr std::ptrdiff_t FIELD_VMATRIX = 0x14;
                inline constexpr std::ptrdiff_t FIELD_CLASSPTR = 0xC;
                inline constexpr std::ptrdiff_t FIELD_EMBEDDED = 0xA;
                inline constexpr std::ptrdiff_t FIELD_FUNCTION = 0x13;
                inline constexpr std::ptrdiff_t FIELD_INTERVAL = 0x17;
                inline constexpr std::ptrdiff_t FIELD_RESOURCE = 0x1C;
                inline constexpr std::ptrdiff_t FIELD_V8_ARRAY = 0x33;
                inline constexpr std::ptrdiff_t FIELD_V8_VALUE = 0x31;
                inline constexpr std::ptrdiff_t FIELD_VECTOR2D = 0x19;
                inline constexpr std::ptrdiff_t FIELD_VECTOR4D = 0x1B;
                inline constexpr std::ptrdiff_t FIELD_CHARACTER = 0x8;
                inline constexpr std::ptrdiff_t FIELD_HMATERIAL = 0x29;
                inline constexpr std::ptrdiff_t FIELD_MATRIX3X4 = 0x3E;
                inline constexpr std::ptrdiff_t FIELD_SOUNDNAME = 0x11;
                inline constexpr std::ptrdiff_t FIELD_TYPECOUNT = 0x53;
                inline constexpr std::ptrdiff_t FIELD_UTLSTRING = 0x35;
                inline constexpr std::ptrdiff_t FIELD_V8_OBJECT = 0x32;
                inline constexpr std::ptrdiff_t FIELD_AMMO_INDEX = 0x43;
                inline constexpr std::ptrdiff_t FIELD_CTRANSFORM = 0x3B;
                inline constexpr std::ptrdiff_t FIELD_QUATERNION = 0x4;
                inline constexpr std::ptrdiff_t FIELD_ENGINE_TICK = 0x4D;
                inline constexpr std::ptrdiff_t FIELD_ENGINE_TIME = 0x4C;
                inline constexpr std::ptrdiff_t FIELD_TYPEUNKNOWN = 0x1D;
                inline constexpr std::ptrdiff_t FIELD_CONDITION_ID = 0x44;
                inline constexpr std::ptrdiff_t FIELD_GLOBALSYMBOL = 0x4F;
                inline constexpr std::ptrdiff_t FIELD_HRENDERTEXTURE = 0x37;
                inline constexpr std::ptrdiff_t FIELD_UTLSTRINGTOKEN = 0x26;
                inline constexpr std::ptrdiff_t FIELD_WORLD_GROUP_ID = 0x4E;
                inline constexpr std::ptrdiff_t FIELD_HPOSTPROCESSING = 0x3D;
                inline constexpr std::ptrdiff_t FIELD_MODIFIER_HANDLE = 0x46;
                inline constexpr std::ptrdiff_t FIELD_POSITION_VECTOR = 0xE;
                inline constexpr std::ptrdiff_t FIELD_ROTATION_VECTOR = 0x47;
                inline constexpr std::ptrdiff_t FIELD_CMOTIONTRANSFORM = 0x40;
                inline constexpr std::ptrdiff_t FIELD_STRING_AND_TOKEN = 0x4B;
                inline constexpr std::ptrdiff_t FIELD_V8_CALLBACK_INFO = 0x34;
                inline constexpr std::ptrdiff_t FIELD_ATTACHMENT_HANDLE = 0x42;
                inline constexpr std::ptrdiff_t FIELD_QANGLE_WORLDSPACE = 0x2E;
                inline constexpr std::ptrdiff_t FIELD_HNMGRAPHDEFINITION = 0x50;
                inline constexpr std::ptrdiff_t FIELD_VMATRIX_WORLDSPACE = 0x15;
                inline constexpr std::ptrdiff_t FIELD_HSCRIPT_LIGHTBINDING = 0x30;
                inline constexpr std::ptrdiff_t FIELD_HSCRIPT_NEW_INSTANCE = 0x24;
                inline constexpr std::ptrdiff_t FIELD_MATRIX3X4_WORLDSPACE = 0x16;
                inline constexpr std::ptrdiff_t FIELD_CTRANSFORM_WORLDSPACE = 0x3C;
                inline constexpr std::ptrdiff_t FIELD_QUATERNION_WORLDSPACE = 0x2F;
                inline constexpr std::ptrdiff_t FIELD_NETWORK_QUANTIZED_FLOAT = 0x2C;
                inline constexpr std::ptrdiff_t FIELD_POSITIVEINTEGER_OR_NULL = 0x23;
                inline constexpr std::ptrdiff_t FIELD_NETWORK_QUANTIZED_VECTOR = 0x2B;
                inline constexpr std::ptrdiff_t FIELD_HPARTICLESYSTEMDEFINITION = 0x38;
                inline constexpr std::ptrdiff_t FIELD_NETWORK_QUANTIZED_VECTORWS = 0x51;
                inline constexpr std::ptrdiff_t FIELD_ROTATION_VECTOR_WORLDSPACE = 0x48;
                inline constexpr std::ptrdiff_t DEPRECATED_FIELD_AI_SCHEDULE_BITS = 0x45;
                inline constexpr std::ptrdiff_t FIELD_CMOTIONTRANSFORM_WORLDSPACE = 0x41;
                inline constexpr std::ptrdiff_t FIELD_DIRECTION_VECTOR_WORLDSPACE = 0x2D;
                inline constexpr std::ptrdiff_t FIELD_NETWORK_ORIGIN_CELL_QUANTIZED_VECTOR = 0x28;
                inline constexpr std::ptrdiff_t FIELD_NETWORK_ORIGIN_CELL_QUANTIZED_VECTORWS = 0x52;
                inline constexpr std::ptrdiff_t FIELD_NETWORK_ORIGIN_CELL_QUANTIZED_POSITION_VECTOR = 0x36;
            }
            namespace ThreeState_t {
                inline constexpr std::ptrdiff_t TRS_NONE = 0x2;
                inline constexpr std::ptrdiff_t TRS_TRUE = 0x1;
                inline constexpr std::ptrdiff_t TRS_FALSE = 0x0;
            }
        }
    }
}
