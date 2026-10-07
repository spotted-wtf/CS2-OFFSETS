public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class rendersystemdx11_dll {
            public static partial class RsBlendStateDesc_t {
                public const long m_blendOpBits = 0x0;
                public const long m_srcBlendBits = 0x0;
                public const long m_destBlendBits = 0x4;
                public const long m_blendEnableBits = 0x1C;
                public const long m_blendOpAlphaBits = 0x18;
                public const long m_srcBlendAlphaBits = 0x8;
                public const long m_destBlendAlphaBits = 0xC;
                public const long m_srgbWriteEnableBits = 0x1D;
                public const long m_bAlphaToCoverageEnable = 0x0;
                public const long m_bIndependentBlendEnable = 0x0;
                public const long m_renderTargetWriteMaskBits = 0x10;
            }
            public static partial class VsInputSignature_t {
                public const long m_elems = 0x0;
                public const long m_depth_elems = 0x18;
            }
            public static partial class RsStencilStateDesc_t {
                public const long m_bStencilEnable = 0x0;
                public const long m_backStencilFunc = 0x0;
                public const long m_frontStencilFunc = 0x0;
                public const long m_nStencilReadMask = 0x4;
                public const long m_backStencilFailOp = 0x0;
                public const long m_backStencilPassOp = 0x0;
                public const long m_nStencilWriteMask = 0x5;
                public const long m_frontStencilFailOp = 0x0;
                public const long m_frontStencilPassOp = 0x0;
                public const long m_backStencilDepthFailOp = 0x0;
                public const long m_frontStencilDepthFailOp = 0x0;
            }
            public static partial class RsRasterizerStateDesc_t {
                public const long m_nCullMode = 0x1;
                public const long m_nFillMode = 0x0;
                public const long m_nDepthBias = 0x4;
                public const long m_bDepthClipEnable = 0x2;
                public const long m_flDepthBiasClamp = 0x8;
                public const long m_bMultisampleEnable = 0x3;
                public const long m_flSlopeScaledDepthBias = 0xC;
            }
            public static partial class RenderInputLayoutField_t {
                public const long m_nSlot = 0x2A;
                public const long m_nOffset = 0x28;
                public const long m_nSlotType = 0x2B;
                public const long m_pSemanticName = 0x0;
                public const long m_nSemanticIndex = 0x20;
                public const long m_szShaderSemantic = 0x2C;
            }
            public static partial class SheetSequenceIntegerId_t {
                public const long m_Value = 0x0;
            }
            public static partial class RsDepthStencilStateDesc_t {
                public const long m_depthFunc = 0x0;
                public const long m_stencilState = 0x2;
                public const long m_bDepthTestEnable = 0x0;
                public const long m_bDepthWriteEnable = 0x0;
            }
            public static partial class VsInputSignatureElement_t {
                public const long m_pName = 0x0;
                public const long m_pSemantic = 0x40;
                public const long m_pD3DSemanticName = 0x80;
                public const long m_nD3DSemanticIndex = 0xC0;
            }
            public static partial class RsCullMode_t {
                public const long RS_CULL_BACK = 0x1;
                public const long RS_CULL_NONE = 0x0;
                public const long RS_CULL_FRONT = 0x2;
            }
            public static partial class RsFillMode_t {
                public const long RS_FILL_SOLID = 0x0;
                public const long RS_FILL_WIREFRAME = 0x1;
            }
            public static partial class RsComparison_t {
                public const long RS_CMP_LESS = 0x1;
                public const long RS_CMP_EQUAL = 0x2;
                public const long RS_CMP_NEVER = 0x0;
                public const long RS_CMP_ALWAYS = 0x7;
                public const long RS_CMP_CLOSER = 0x9;
                public const long RS_CMP_FARTHER = 0xC;
                public const long RS_CMP_GREATER = 0x4;
                public const long RS_CMP_FUNC_MASK = 0x7;
                public const long RS_CMP_NOT_EQUAL = 0x5;
                public const long RS_CMP_LESS_EQUAL = 0x3;
                public const long RS_CMP_CLOSER_EQUAL = 0xB;
                public const long RS_CMP_FARTHER_EQUAL = 0xE;
                public const long RS_CMP_GREATER_EQUAL = 0x6;
                public const long RS_CMP_CLOSER_FARTHER_FLAG = 0x8;
            }
            public static partial class UpscalerType_t {
                public const long UPSCALER_NONE = 0x0;
                public const long UPSCALER_COUNT = 0x5;
                public const long UPSCALER_AMD_FSR2 = 0x1;
                public const long UPSCALER_AMD_FSR3 = 0x2;
                public const long UPSCALER_INTEL_XESS = 0x4;
                public const long UPSCALER_NVIDIA_DLSS = 0x3;
            }
            public static partial class RenderSlotType_t {
                public const long RENDER_SLOT_INVALID = -0x1;
                public const long RENDER_SLOT_PER_VERTEX = 0x0;
                public const long RENDER_SLOT_PER_INSTANCE = 0x1;
            }
            public static partial class RenderBufferFlags_t {
                public const long RENDER_BUFFER_USAGE_NONE = 0x0;
                public const long RENDER_BUFFER_POOL_ALLOCATED = 0x800;
                public const long RENDER_BUFFER_DYNAMIC_ZERO_COPY = 0x4000;
                public const long RENDER_BUFFER_STRUCTURED_BUFFER = 0x20;
                public const long RENDER_BUFFER_BYTEADDRESS_BUFFER = 0x10;
                public const long RENDER_BUFFER_USAGE_INDEX_BUFFER = 0x2;
                public const long RENDER_BUFFER_USAGE_VERTEX_BUFFER = 0x1;
                public const long RENDER_BUFFER_IMMOVABLE_ALLOCATION = 0x2000;
                public const long RENDER_BUFFER_SHADER_BINDING_TABLE = 0x400;
                public const long RENDER_BUFFER_USAGE_SHADER_RESOURCE = 0x4;
                public const long RENDER_BUFFER_ACCELERATION_STRUCTURE = 0x200;
                public const long RENDER_BUFFER_UAV_DRAW_INDIRECT_ARGS = 0x100;
                public const long RENDER_BUFFER_USAGE_UNORDERED_ACCESS = 0x8;
                public const long RENDER_BUFFER_USAGE_CONDITIONAL_RENDERING = 0x1000;
            }
            public static partial class RenderPrimitiveType_t {
                public const long RENDER_PRIM_LINES = 0x1;
                public const long RENDER_PRIM_POINTS = 0x0;
                public const long RENDER_PRIM_TRIANGLES = 0x5;
                public const long RENDER_PRIM_LINE_STRIP = 0x3;
                public const long RENDER_PRIM_TYPE_COUNT = 0xD;
                public const long RENDER_PRIM_MESH_SHADER = 0xC;
                public const long RENDER_PRIM_HETEROGENOUS = 0xA;
                public const long RENDER_PRIM_COMPUTE_SHADER = 0xB;
                public const long RENDER_PRIM_TRIANGLE_STRIP = 0x7;
                public const long RENDER_PRIM_INSTANCED_QUADS = 0x9;
                public const long RENDER_PRIM_LINES_WITH_ADJACENCY = 0x2;
                public const long RENDER_PRIM_TRIANGLES_WITH_ADJACENCY = 0x6;
                public const long RENDER_PRIM_LINE_STRIP_WITH_ADJACENCY = 0x4;
                public const long RENDER_PRIM_TRIANGLE_STRIP_WITH_ADJACENCY = 0x8;
            }
            public static partial class InputLayoutVariation_t {
                public const long INPUT_LAYOUT_VARIATION_MAX = 0x3;
                public const long INPUT_LAYOUT_VARIATION_DEFAULT = 0x0;
                public const long INPUT_LAYOUT_VARIATION_STREAM1_INSTANCEID = 0x1;
                public const long INPUT_LAYOUT_VARIATION_STREAM1_INSTANCEID_MORPH_VERT_ID = 0x2;
            }
            public static partial class RenderMultisampleType_t {
                public const long RENDER_MULTISAMPLE_2X = 0x1;
                public const long RENDER_MULTISAMPLE_4X = 0x2;
                public const long RENDER_MULTISAMPLE_6X = 0x3;
                public const long RENDER_MULTISAMPLE_8X = 0x4;
                public const long RENDER_MULTISAMPLE_16X = 0x5;
                public const long RENDER_MULTISAMPLE_NONE = 0x0;
                public const long RENDER_MULTISAMPLE_INVALID = -0x1;
                public const long RENDER_MULTISAMPLE_TYPE_COUNT = 0x6;
            }
        }
    }
}
