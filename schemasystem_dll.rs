#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod schemasystem_dll {
            pub mod ResourceId_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod CExampleSchemaVData_Monomorphic {
                pub const m_nExample1: i64 = 0x0;
                pub const m_nExample2: i64 = 0x4;
            }
            pub mod CSchemaSystemInternalRegistration {
                pub const m_KV3: i64 = 0x168;
                pub const m_Color: i64 = 0xE0;
                pub const m_QAngle: i64 = 0x40;
                pub const m_Vector: i64 = 0x8;
                pub const m_Vector2D: i64 = 0x0;
                pub const m_Vector4D: i64 = 0xE4;
                pub const m_VectorWS: i64 = 0x14;
                pub const m_CTransform: i64 = 0x100;
                pub const m_CUtlString: i64 = 0x138;
                pub const m_CUtlSymbol: i64 = 0x140;
                pub const m_Quaternion: i64 = 0x30;
                pub const m_pKeyValues: i64 = 0x120;
                pub const m_DegreeEuler: i64 = 0x64;
                pub const m_RadianEuler: i64 = 0x58;
                pub const m_matrix3x4_t: i64 = 0x80;
                pub const m_stringToken: i64 = 0x144;
                pub const m_matrix3x4a_t: i64 = 0xB0;
                pub const m_ResourceTypes: i64 = 0x160;
                pub const m_VectorAligned: i64 = 0x20;
                pub const m_RotationVector: i64 = 0x4C;
                pub const m_CUtlBinaryBlock: i64 = 0x128;
                pub const m_QuaternionStorage: i64 = 0x70;
                pub const m_stringTokenWithStorage: i64 = 0x148;
            }
            pub mod CExampleSchemaVData_PolymorphicBase {
                pub const m_nBase: i64 = 0x8;
            }
            pub mod CExampleSchemaVData_PolymorphicDerivedA {
                pub const m_nDerivedA: i64 = 0x10;
            }
            pub mod CExampleSchemaVData_PolymorphicDerivedB {
                pub const m_nDerivedB: i64 = 0x10;
            }
            pub mod InfoForResourceTypeCResourceManifestInternal {

            }
            pub mod fieldtype_t {
                pub const FIELD_SHIM: i64 = 0x3F;
                pub const FIELD_TICK: i64 = 0x10;
                pub const FIELD_TIME: i64 = 0xF;
                pub const FIELD_VOID: i64 = 0x0;
                pub const FIELD_INPUT: i64 = 0x12;
                pub const FIELD_INT16: i64 = 0x7;
                pub const FIELD_INT32: i64 = 0x5;
                pub const FIELD_INT64: i64 = 0x1A;
                pub const FIELD_UINT8: i64 = 0x39;
                pub const FIELD_CUSTOM: i64 = 0xB;
                pub const FIELD_HMODEL: i64 = 0x2A;
                pub const FIELD_HVDATA: i64 = 0x49;
                pub const FIELD_QANGLE: i64 = 0x27;
                pub const FIELD_STRING: i64 = 0x2;
                pub const FIELD_UINT16: i64 = 0x3A;
                pub const FIELD_UINT32: i64 = 0x25;
                pub const FIELD_UINT64: i64 = 0x21;
                pub const FIELD_UNUSED: i64 = 0x18;
                pub const FIELD_VECTOR: i64 = 0x3;
                pub const FIELD_BOOLEAN: i64 = 0x6;
                pub const FIELD_COLOR32: i64 = 0x9;
                pub const FIELD_CSTRING: i64 = 0x1E;
                pub const FIELD_EHANDLE: i64 = 0xD;
                pub const FIELD_FLOAT32: i64 = 0x1;
                pub const FIELD_FLOAT64: i64 = 0x22;
                pub const FIELD_HSCRIPT: i64 = 0x1F;
                pub const FIELD_SCALE32: i64 = 0x4A;
                pub const FIELD_VARIANT: i64 = 0x20;
                pub const FIELD_VMATRIX: i64 = 0x14;
                pub const FIELD_CLASSPTR: i64 = 0xC;
                pub const FIELD_EMBEDDED: i64 = 0xA;
                pub const FIELD_FUNCTION: i64 = 0x13;
                pub const FIELD_INTERVAL: i64 = 0x17;
                pub const FIELD_RESOURCE: i64 = 0x1C;
                pub const FIELD_V8_ARRAY: i64 = 0x33;
                pub const FIELD_V8_VALUE: i64 = 0x31;
                pub const FIELD_VECTOR2D: i64 = 0x19;
                pub const FIELD_VECTOR4D: i64 = 0x1B;
                pub const FIELD_CHARACTER: i64 = 0x8;
                pub const FIELD_HMATERIAL: i64 = 0x29;
                pub const FIELD_MATRIX3X4: i64 = 0x3E;
                pub const FIELD_SOUNDNAME: i64 = 0x11;
                pub const FIELD_TYPECOUNT: i64 = 0x53;
                pub const FIELD_UTLSTRING: i64 = 0x35;
                pub const FIELD_V8_OBJECT: i64 = 0x32;
                pub const FIELD_AMMO_INDEX: i64 = 0x43;
                pub const FIELD_CTRANSFORM: i64 = 0x3B;
                pub const FIELD_QUATERNION: i64 = 0x4;
                pub const FIELD_ENGINE_TICK: i64 = 0x4D;
                pub const FIELD_ENGINE_TIME: i64 = 0x4C;
                pub const FIELD_TYPEUNKNOWN: i64 = 0x1D;
                pub const FIELD_CONDITION_ID: i64 = 0x44;
                pub const FIELD_GLOBALSYMBOL: i64 = 0x4F;
                pub const FIELD_HRENDERTEXTURE: i64 = 0x37;
                pub const FIELD_UTLSTRINGTOKEN: i64 = 0x26;
                pub const FIELD_WORLD_GROUP_ID: i64 = 0x4E;
                pub const FIELD_HPOSTPROCESSING: i64 = 0x3D;
                pub const FIELD_MODIFIER_HANDLE: i64 = 0x46;
                pub const FIELD_POSITION_VECTOR: i64 = 0xE;
                pub const FIELD_ROTATION_VECTOR: i64 = 0x47;
                pub const FIELD_CMOTIONTRANSFORM: i64 = 0x40;
                pub const FIELD_STRING_AND_TOKEN: i64 = 0x4B;
                pub const FIELD_V8_CALLBACK_INFO: i64 = 0x34;
                pub const FIELD_ATTACHMENT_HANDLE: i64 = 0x42;
                pub const FIELD_QANGLE_WORLDSPACE: i64 = 0x2E;
                pub const FIELD_HNMGRAPHDEFINITION: i64 = 0x50;
                pub const FIELD_VMATRIX_WORLDSPACE: i64 = 0x15;
                pub const FIELD_HSCRIPT_LIGHTBINDING: i64 = 0x30;
                pub const FIELD_HSCRIPT_NEW_INSTANCE: i64 = 0x24;
                pub const FIELD_MATRIX3X4_WORLDSPACE: i64 = 0x16;
                pub const FIELD_CTRANSFORM_WORLDSPACE: i64 = 0x3C;
                pub const FIELD_QUATERNION_WORLDSPACE: i64 = 0x2F;
                pub const FIELD_NETWORK_QUANTIZED_FLOAT: i64 = 0x2C;
                pub const FIELD_POSITIVEINTEGER_OR_NULL: i64 = 0x23;
                pub const FIELD_NETWORK_QUANTIZED_VECTOR: i64 = 0x2B;
                pub const FIELD_HPARTICLESYSTEMDEFINITION: i64 = 0x38;
                pub const FIELD_NETWORK_QUANTIZED_VECTORWS: i64 = 0x51;
                pub const FIELD_ROTATION_VECTOR_WORLDSPACE: i64 = 0x48;
                pub const DEPRECATED_FIELD_AI_SCHEDULE_BITS: i64 = 0x45;
                pub const FIELD_CMOTIONTRANSFORM_WORLDSPACE: i64 = 0x41;
                pub const FIELD_DIRECTION_VECTOR_WORLDSPACE: i64 = 0x2D;
                pub const FIELD_NETWORK_ORIGIN_CELL_QUANTIZED_VECTOR: i64 = 0x28;
                pub const FIELD_NETWORK_ORIGIN_CELL_QUANTIZED_VECTORWS: i64 = 0x52;
                pub const FIELD_NETWORK_ORIGIN_CELL_QUANTIZED_POSITION_VECTOR: i64 = 0x36;
            }
            pub mod ThreeState_t {
                pub const TRS_NONE: i64 = 0x2;
                pub const TRS_TRUE: i64 = 0x1;
                pub const TRS_FALSE: i64 = 0x0;
            }
        }
    }
}
