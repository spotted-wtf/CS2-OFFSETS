export namespace cs2_dumper {
    export namespace schemas {
        export namespace rendersystemdx11_dll {
            export namespace RsBlendStateDesc_t {
                export const m_blendOpBits = 0x0;
                export const m_srcBlendBits = 0x0;
                export const m_destBlendBits = 0x4;
                export const m_blendEnableBits = 0x1C;
                export const m_blendOpAlphaBits = 0x18;
                export const m_srcBlendAlphaBits = 0x8;
                export const m_destBlendAlphaBits = 0xC;
                export const m_srgbWriteEnableBits = 0x1D;
                export const m_bAlphaToCoverageEnable = 0x0;
                export const m_bIndependentBlendEnable = 0x0;
                export const m_renderTargetWriteMaskBits = 0x10;
            }
            export namespace VsInputSignature_t {
                export const m_elems = 0x0;
                export const m_depth_elems = 0x18;
            }
            export namespace RsStencilStateDesc_t {
                export const m_bStencilEnable = 0x0;
                export const m_backStencilFunc = 0x0;
                export const m_frontStencilFunc = 0x0;
                export const m_nStencilReadMask = 0x4;
                export const m_backStencilFailOp = 0x0;
                export const m_backStencilPassOp = 0x0;
                export const m_nStencilWriteMask = 0x5;
                export const m_frontStencilFailOp = 0x0;
                export const m_frontStencilPassOp = 0x0;
                export const m_backStencilDepthFailOp = 0x0;
                export const m_frontStencilDepthFailOp = 0x0;
            }
            export namespace RsRasterizerStateDesc_t {
                export const m_nCullMode = 0x1;
                export const m_nFillMode = 0x0;
                export const m_nDepthBias = 0x4;
                export const m_bDepthClipEnable = 0x2;
                export const m_flDepthBiasClamp = 0x8;
                export const m_bMultisampleEnable = 0x3;
                export const m_flSlopeScaledDepthBias = 0xC;
            }
            export namespace RenderInputLayoutField_t {
                export const m_nSlot = 0x2A;
                export const m_nOffset = 0x28;
                export const m_nSlotType = 0x2B;
                export const m_pSemanticName = 0x0;
                export const m_nSemanticIndex = 0x20;
                export const m_szShaderSemantic = 0x2C;
            }
            export namespace SheetSequenceIntegerId_t {
                export const m_Value = 0x0;
            }
            export namespace RsDepthStencilStateDesc_t {
                export const m_depthFunc = 0x0;
                export const m_stencilState = 0x2;
                export const m_bDepthTestEnable = 0x0;
                export const m_bDepthWriteEnable = 0x0;
            }
            export namespace VsInputSignatureElement_t {
                export const m_pName = 0x0;
                export const m_pSemantic = 0x40;
                export const m_pD3DSemanticName = 0x80;
                export const m_nD3DSemanticIndex = 0xC0;
            }
            export namespace RsCullMode_t {
                export const RS_CULL_BACK = 0x1;
                export const RS_CULL_NONE = 0x0;
                export const RS_CULL_FRONT = 0x2;
            }
            export namespace RsFillMode_t {
                export const RS_FILL_SOLID = 0x0;
                export const RS_FILL_WIREFRAME = 0x1;
            }
            export namespace RsComparison_t {
                export const RS_CMP_LESS = 0x1;
                export const RS_CMP_EQUAL = 0x2;
                export const RS_CMP_NEVER = 0x0;
                export const RS_CMP_ALWAYS = 0x7;
                export const RS_CMP_CLOSER = 0x9;
                export const RS_CMP_FARTHER = 0xC;
                export const RS_CMP_GREATER = 0x4;
                export const RS_CMP_FUNC_MASK = 0x7;
                export const RS_CMP_NOT_EQUAL = 0x5;
                export const RS_CMP_LESS_EQUAL = 0x3;
                export const RS_CMP_CLOSER_EQUAL = 0xB;
                export const RS_CMP_FARTHER_EQUAL = 0xE;
                export const RS_CMP_GREATER_EQUAL = 0x6;
                export const RS_CMP_CLOSER_FARTHER_FLAG = 0x8;
            }
            export namespace UpscalerType_t {
                export const UPSCALER_NONE = 0x0;
                export const UPSCALER_COUNT = 0x5;
                export const UPSCALER_AMD_FSR2 = 0x1;
                export const UPSCALER_AMD_FSR3 = 0x2;
                export const UPSCALER_INTEL_XESS = 0x4;
                export const UPSCALER_NVIDIA_DLSS = 0x3;
            }
            export namespace RenderSlotType_t {
                export const RENDER_SLOT_INVALID = -0x1;
                export const RENDER_SLOT_PER_VERTEX = 0x0;
                export const RENDER_SLOT_PER_INSTANCE = 0x1;
            }
            export namespace RenderBufferFlags_t {
                export const RENDER_BUFFER_USAGE_NONE = 0x0;
                export const RENDER_BUFFER_POOL_ALLOCATED = 0x800;
                export const RENDER_BUFFER_DYNAMIC_ZERO_COPY = 0x4000;
                export const RENDER_BUFFER_STRUCTURED_BUFFER = 0x20;
                export const RENDER_BUFFER_BYTEADDRESS_BUFFER = 0x10;
                export const RENDER_BUFFER_USAGE_INDEX_BUFFER = 0x2;
                export const RENDER_BUFFER_USAGE_VERTEX_BUFFER = 0x1;
                export const RENDER_BUFFER_IMMOVABLE_ALLOCATION = 0x2000;
                export const RENDER_BUFFER_SHADER_BINDING_TABLE = 0x400;
                export const RENDER_BUFFER_USAGE_SHADER_RESOURCE = 0x4;
                export const RENDER_BUFFER_ACCELERATION_STRUCTURE = 0x200;
                export const RENDER_BUFFER_UAV_DRAW_INDIRECT_ARGS = 0x100;
                export const RENDER_BUFFER_USAGE_UNORDERED_ACCESS = 0x8;
                export const RENDER_BUFFER_USAGE_CONDITIONAL_RENDERING = 0x1000;
            }
            export namespace RenderPrimitiveType_t {
                export const RENDER_PRIM_LINES = 0x1;
                export const RENDER_PRIM_POINTS = 0x0;
                export const RENDER_PRIM_TRIANGLES = 0x5;
                export const RENDER_PRIM_LINE_STRIP = 0x3;
                export const RENDER_PRIM_TYPE_COUNT = 0xD;
                export const RENDER_PRIM_MESH_SHADER = 0xC;
                export const RENDER_PRIM_HETEROGENOUS = 0xA;
                export const RENDER_PRIM_COMPUTE_SHADER = 0xB;
                export const RENDER_PRIM_TRIANGLE_STRIP = 0x7;
                export const RENDER_PRIM_INSTANCED_QUADS = 0x9;
                export const RENDER_PRIM_LINES_WITH_ADJACENCY = 0x2;
                export const RENDER_PRIM_TRIANGLES_WITH_ADJACENCY = 0x6;
                export const RENDER_PRIM_LINE_STRIP_WITH_ADJACENCY = 0x4;
                export const RENDER_PRIM_TRIANGLE_STRIP_WITH_ADJACENCY = 0x8;
            }
            export namespace InputLayoutVariation_t {
                export const INPUT_LAYOUT_VARIATION_MAX = 0x3;
                export const INPUT_LAYOUT_VARIATION_DEFAULT = 0x0;
                export const INPUT_LAYOUT_VARIATION_STREAM1_INSTANCEID = 0x1;
                export const INPUT_LAYOUT_VARIATION_STREAM1_INSTANCEID_MORPH_VERT_ID = 0x2;
            }
            export namespace RenderMultisampleType_t {
                export const RENDER_MULTISAMPLE_2X = 0x1;
                export const RENDER_MULTISAMPLE_4X = 0x2;
                export const RENDER_MULTISAMPLE_6X = 0x3;
                export const RENDER_MULTISAMPLE_8X = 0x4;
                export const RENDER_MULTISAMPLE_16X = 0x5;
                export const RENDER_MULTISAMPLE_NONE = 0x0;
                export const RENDER_MULTISAMPLE_INVALID = -0x1;
                export const RENDER_MULTISAMPLE_TYPE_COUNT = 0x6;
            }
        }
    }
}
