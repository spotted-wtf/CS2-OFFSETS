#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace schemas {
        namespace rendersystemdx11_dll {
            namespace RsBlendStateDesc_t {
                inline constexpr std::ptrdiff_t m_blendOpBits = 0x0;
                inline constexpr std::ptrdiff_t m_srcBlendBits = 0x0;
                inline constexpr std::ptrdiff_t m_destBlendBits = 0x4;
                inline constexpr std::ptrdiff_t m_blendEnableBits = 0x1C;
                inline constexpr std::ptrdiff_t m_blendOpAlphaBits = 0x18;
                inline constexpr std::ptrdiff_t m_srcBlendAlphaBits = 0x8;
                inline constexpr std::ptrdiff_t m_destBlendAlphaBits = 0xC;
                inline constexpr std::ptrdiff_t m_srgbWriteEnableBits = 0x1D;
                inline constexpr std::ptrdiff_t m_bAlphaToCoverageEnable = 0x0;
                inline constexpr std::ptrdiff_t m_bIndependentBlendEnable = 0x0;
                inline constexpr std::ptrdiff_t m_renderTargetWriteMaskBits = 0x10;
            }
            namespace VsInputSignature_t {
                inline constexpr std::ptrdiff_t m_elems = 0x0;
                inline constexpr std::ptrdiff_t m_depth_elems = 0x18;
            }
            namespace RsStencilStateDesc_t {
                inline constexpr std::ptrdiff_t m_bStencilEnable = 0x0;
                inline constexpr std::ptrdiff_t m_backStencilFunc = 0x0;
                inline constexpr std::ptrdiff_t m_frontStencilFunc = 0x0;
                inline constexpr std::ptrdiff_t m_nStencilReadMask = 0x4;
                inline constexpr std::ptrdiff_t m_backStencilFailOp = 0x0;
                inline constexpr std::ptrdiff_t m_backStencilPassOp = 0x0;
                inline constexpr std::ptrdiff_t m_nStencilWriteMask = 0x5;
                inline constexpr std::ptrdiff_t m_frontStencilFailOp = 0x0;
                inline constexpr std::ptrdiff_t m_frontStencilPassOp = 0x0;
                inline constexpr std::ptrdiff_t m_backStencilDepthFailOp = 0x0;
                inline constexpr std::ptrdiff_t m_frontStencilDepthFailOp = 0x0;
            }
            namespace RsRasterizerStateDesc_t {
                inline constexpr std::ptrdiff_t m_nCullMode = 0x1;
                inline constexpr std::ptrdiff_t m_nFillMode = 0x0;
                inline constexpr std::ptrdiff_t m_nDepthBias = 0x4;
                inline constexpr std::ptrdiff_t m_bDepthClipEnable = 0x2;
                inline constexpr std::ptrdiff_t m_flDepthBiasClamp = 0x8;
                inline constexpr std::ptrdiff_t m_bMultisampleEnable = 0x3;
                inline constexpr std::ptrdiff_t m_flSlopeScaledDepthBias = 0xC;
            }
            namespace RenderInputLayoutField_t {
                inline constexpr std::ptrdiff_t m_nSlot = 0x2A;
                inline constexpr std::ptrdiff_t m_nOffset = 0x28;
                inline constexpr std::ptrdiff_t m_nSlotType = 0x2B;
                inline constexpr std::ptrdiff_t m_pSemanticName = 0x0;
                inline constexpr std::ptrdiff_t m_nSemanticIndex = 0x20;
                inline constexpr std::ptrdiff_t m_szShaderSemantic = 0x2C;
            }
            namespace SheetSequenceIntegerId_t {
                inline constexpr std::ptrdiff_t m_Value = 0x0;
            }
            namespace RsDepthStencilStateDesc_t {
                inline constexpr std::ptrdiff_t m_depthFunc = 0x0;
                inline constexpr std::ptrdiff_t m_stencilState = 0x2;
                inline constexpr std::ptrdiff_t m_bDepthTestEnable = 0x0;
                inline constexpr std::ptrdiff_t m_bDepthWriteEnable = 0x0;
            }
            namespace VsInputSignatureElement_t {
                inline constexpr std::ptrdiff_t m_pName = 0x0;
                inline constexpr std::ptrdiff_t m_pSemantic = 0x40;
                inline constexpr std::ptrdiff_t m_pD3DSemanticName = 0x80;
                inline constexpr std::ptrdiff_t m_nD3DSemanticIndex = 0xC0;
            }
            namespace RsCullMode_t {
                inline constexpr std::ptrdiff_t RS_CULL_BACK = 0x1;
                inline constexpr std::ptrdiff_t RS_CULL_NONE = 0x0;
                inline constexpr std::ptrdiff_t RS_CULL_FRONT = 0x2;
            }
            namespace RsFillMode_t {
                inline constexpr std::ptrdiff_t RS_FILL_SOLID = 0x0;
                inline constexpr std::ptrdiff_t RS_FILL_WIREFRAME = 0x1;
            }
            namespace RsComparison_t {
                inline constexpr std::ptrdiff_t RS_CMP_LESS = 0x1;
                inline constexpr std::ptrdiff_t RS_CMP_EQUAL = 0x2;
                inline constexpr std::ptrdiff_t RS_CMP_NEVER = 0x0;
                inline constexpr std::ptrdiff_t RS_CMP_ALWAYS = 0x7;
                inline constexpr std::ptrdiff_t RS_CMP_CLOSER = 0x9;
                inline constexpr std::ptrdiff_t RS_CMP_FARTHER = 0xC;
                inline constexpr std::ptrdiff_t RS_CMP_GREATER = 0x4;
                inline constexpr std::ptrdiff_t RS_CMP_FUNC_MASK = 0x7;
                inline constexpr std::ptrdiff_t RS_CMP_NOT_EQUAL = 0x5;
                inline constexpr std::ptrdiff_t RS_CMP_LESS_EQUAL = 0x3;
                inline constexpr std::ptrdiff_t RS_CMP_CLOSER_EQUAL = 0xB;
                inline constexpr std::ptrdiff_t RS_CMP_FARTHER_EQUAL = 0xE;
                inline constexpr std::ptrdiff_t RS_CMP_GREATER_EQUAL = 0x6;
                inline constexpr std::ptrdiff_t RS_CMP_CLOSER_FARTHER_FLAG = 0x8;
            }
            namespace UpscalerType_t {
                inline constexpr std::ptrdiff_t UPSCALER_NONE = 0x0;
                inline constexpr std::ptrdiff_t UPSCALER_COUNT = 0x5;
                inline constexpr std::ptrdiff_t UPSCALER_AMD_FSR2 = 0x1;
                inline constexpr std::ptrdiff_t UPSCALER_AMD_FSR3 = 0x2;
                inline constexpr std::ptrdiff_t UPSCALER_INTEL_XESS = 0x4;
                inline constexpr std::ptrdiff_t UPSCALER_NVIDIA_DLSS = 0x3;
            }
            namespace RenderSlotType_t {
                inline constexpr std::ptrdiff_t RENDER_SLOT_INVALID = -0x1;
                inline constexpr std::ptrdiff_t RENDER_SLOT_PER_VERTEX = 0x0;
                inline constexpr std::ptrdiff_t RENDER_SLOT_PER_INSTANCE = 0x1;
            }
            namespace RenderBufferFlags_t {
                inline constexpr std::ptrdiff_t RENDER_BUFFER_USAGE_NONE = 0x0;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_POOL_ALLOCATED = 0x800;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_DYNAMIC_ZERO_COPY = 0x4000;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_STRUCTURED_BUFFER = 0x20;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_BYTEADDRESS_BUFFER = 0x10;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_USAGE_INDEX_BUFFER = 0x2;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_USAGE_VERTEX_BUFFER = 0x1;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_IMMOVABLE_ALLOCATION = 0x2000;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_SHADER_BINDING_TABLE = 0x400;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_USAGE_SHADER_RESOURCE = 0x4;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_ACCELERATION_STRUCTURE = 0x200;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_UAV_DRAW_INDIRECT_ARGS = 0x100;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_USAGE_UNORDERED_ACCESS = 0x8;
                inline constexpr std::ptrdiff_t RENDER_BUFFER_USAGE_CONDITIONAL_RENDERING = 0x1000;
            }
            namespace RenderPrimitiveType_t {
                inline constexpr std::ptrdiff_t RENDER_PRIM_LINES = 0x1;
                inline constexpr std::ptrdiff_t RENDER_PRIM_POINTS = 0x0;
                inline constexpr std::ptrdiff_t RENDER_PRIM_TRIANGLES = 0x5;
                inline constexpr std::ptrdiff_t RENDER_PRIM_LINE_STRIP = 0x3;
                inline constexpr std::ptrdiff_t RENDER_PRIM_TYPE_COUNT = 0xD;
                inline constexpr std::ptrdiff_t RENDER_PRIM_MESH_SHADER = 0xC;
                inline constexpr std::ptrdiff_t RENDER_PRIM_HETEROGENOUS = 0xA;
                inline constexpr std::ptrdiff_t RENDER_PRIM_COMPUTE_SHADER = 0xB;
                inline constexpr std::ptrdiff_t RENDER_PRIM_TRIANGLE_STRIP = 0x7;
                inline constexpr std::ptrdiff_t RENDER_PRIM_INSTANCED_QUADS = 0x9;
                inline constexpr std::ptrdiff_t RENDER_PRIM_LINES_WITH_ADJACENCY = 0x2;
                inline constexpr std::ptrdiff_t RENDER_PRIM_TRIANGLES_WITH_ADJACENCY = 0x6;
                inline constexpr std::ptrdiff_t RENDER_PRIM_LINE_STRIP_WITH_ADJACENCY = 0x4;
                inline constexpr std::ptrdiff_t RENDER_PRIM_TRIANGLE_STRIP_WITH_ADJACENCY = 0x8;
            }
            namespace InputLayoutVariation_t {
                inline constexpr std::ptrdiff_t INPUT_LAYOUT_VARIATION_MAX = 0x3;
                inline constexpr std::ptrdiff_t INPUT_LAYOUT_VARIATION_DEFAULT = 0x0;
                inline constexpr std::ptrdiff_t INPUT_LAYOUT_VARIATION_STREAM1_INSTANCEID = 0x1;
                inline constexpr std::ptrdiff_t INPUT_LAYOUT_VARIATION_STREAM1_INSTANCEID_MORPH_VERT_ID = 0x2;
            }
            namespace RenderMultisampleType_t {
                inline constexpr std::ptrdiff_t RENDER_MULTISAMPLE_2X = 0x1;
                inline constexpr std::ptrdiff_t RENDER_MULTISAMPLE_4X = 0x2;
                inline constexpr std::ptrdiff_t RENDER_MULTISAMPLE_6X = 0x3;
                inline constexpr std::ptrdiff_t RENDER_MULTISAMPLE_8X = 0x4;
                inline constexpr std::ptrdiff_t RENDER_MULTISAMPLE_16X = 0x5;
                inline constexpr std::ptrdiff_t RENDER_MULTISAMPLE_NONE = 0x0;
                inline constexpr std::ptrdiff_t RENDER_MULTISAMPLE_INVALID = -0x1;
                inline constexpr std::ptrdiff_t RENDER_MULTISAMPLE_TYPE_COUNT = 0x6;
            }
        }
    }
}
