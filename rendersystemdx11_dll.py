class cs2_dumper:
    class schemas:
        class rendersystemdx11_dll:
            class RsBlendStateDesc_t:
                m_blendOpBits = 0x0
                m_srcBlendBits = 0x0
                m_destBlendBits = 0x4
                m_blendEnableBits = 0x1C
                m_blendOpAlphaBits = 0x18
                m_srcBlendAlphaBits = 0x8
                m_destBlendAlphaBits = 0xC
                m_srgbWriteEnableBits = 0x1D
                m_bAlphaToCoverageEnable = 0x0
                m_bIndependentBlendEnable = 0x0
                m_renderTargetWriteMaskBits = 0x10
            class VsInputSignature_t:
                m_elems = 0x0
                m_depth_elems = 0x18
            class RsStencilStateDesc_t:
                m_bStencilEnable = 0x0
                m_backStencilFunc = 0x0
                m_frontStencilFunc = 0x0
                m_nStencilReadMask = 0x4
                m_backStencilFailOp = 0x0
                m_backStencilPassOp = 0x0
                m_nStencilWriteMask = 0x5
                m_frontStencilFailOp = 0x0
                m_frontStencilPassOp = 0x0
                m_backStencilDepthFailOp = 0x0
                m_frontStencilDepthFailOp = 0x0
            class RsRasterizerStateDesc_t:
                m_nCullMode = 0x1
                m_nFillMode = 0x0
                m_nDepthBias = 0x4
                m_bDepthClipEnable = 0x2
                m_flDepthBiasClamp = 0x8
                m_bMultisampleEnable = 0x3
                m_flSlopeScaledDepthBias = 0xC
            class RenderInputLayoutField_t:
                m_nSlot = 0x2A
                m_nOffset = 0x28
                m_nSlotType = 0x2B
                m_pSemanticName = 0x0
                m_nSemanticIndex = 0x20
                m_szShaderSemantic = 0x2C
            class SheetSequenceIntegerId_t:
                m_Value = 0x0
            class RsDepthStencilStateDesc_t:
                m_depthFunc = 0x0
                m_stencilState = 0x2
                m_bDepthTestEnable = 0x0
                m_bDepthWriteEnable = 0x0
            class VsInputSignatureElement_t:
                m_pName = 0x0
                m_pSemantic = 0x40
                m_pD3DSemanticName = 0x80
                m_nD3DSemanticIndex = 0xC0
            class RsCullMode_t:
                RS_CULL_BACK = 0x1
                RS_CULL_NONE = 0x0
                RS_CULL_FRONT = 0x2
            class RsFillMode_t:
                RS_FILL_SOLID = 0x0
                RS_FILL_WIREFRAME = 0x1
            class RsComparison_t:
                RS_CMP_LESS = 0x1
                RS_CMP_EQUAL = 0x2
                RS_CMP_NEVER = 0x0
                RS_CMP_ALWAYS = 0x7
                RS_CMP_CLOSER = 0x9
                RS_CMP_FARTHER = 0xC
                RS_CMP_GREATER = 0x4
                RS_CMP_FUNC_MASK = 0x7
                RS_CMP_NOT_EQUAL = 0x5
                RS_CMP_LESS_EQUAL = 0x3
                RS_CMP_CLOSER_EQUAL = 0xB
                RS_CMP_FARTHER_EQUAL = 0xE
                RS_CMP_GREATER_EQUAL = 0x6
                RS_CMP_CLOSER_FARTHER_FLAG = 0x8
            class UpscalerType_t:
                UPSCALER_NONE = 0x0
                UPSCALER_COUNT = 0x5
                UPSCALER_AMD_FSR2 = 0x1
                UPSCALER_AMD_FSR3 = 0x2
                UPSCALER_INTEL_XESS = 0x4
                UPSCALER_NVIDIA_DLSS = 0x3
            class RenderSlotType_t:
                RENDER_SLOT_INVALID = -0x1
                RENDER_SLOT_PER_VERTEX = 0x0
                RENDER_SLOT_PER_INSTANCE = 0x1
            class RenderBufferFlags_t:
                RENDER_BUFFER_USAGE_NONE = 0x0
                RENDER_BUFFER_POOL_ALLOCATED = 0x800
                RENDER_BUFFER_DYNAMIC_ZERO_COPY = 0x4000
                RENDER_BUFFER_STRUCTURED_BUFFER = 0x20
                RENDER_BUFFER_BYTEADDRESS_BUFFER = 0x10
                RENDER_BUFFER_USAGE_INDEX_BUFFER = 0x2
                RENDER_BUFFER_USAGE_VERTEX_BUFFER = 0x1
                RENDER_BUFFER_IMMOVABLE_ALLOCATION = 0x2000
                RENDER_BUFFER_SHADER_BINDING_TABLE = 0x400
                RENDER_BUFFER_USAGE_SHADER_RESOURCE = 0x4
                RENDER_BUFFER_ACCELERATION_STRUCTURE = 0x200
                RENDER_BUFFER_UAV_DRAW_INDIRECT_ARGS = 0x100
                RENDER_BUFFER_USAGE_UNORDERED_ACCESS = 0x8
                RENDER_BUFFER_USAGE_CONDITIONAL_RENDERING = 0x1000
            class RenderPrimitiveType_t:
                RENDER_PRIM_LINES = 0x1
                RENDER_PRIM_POINTS = 0x0
                RENDER_PRIM_TRIANGLES = 0x5
                RENDER_PRIM_LINE_STRIP = 0x3
                RENDER_PRIM_TYPE_COUNT = 0xD
                RENDER_PRIM_MESH_SHADER = 0xC
                RENDER_PRIM_HETEROGENOUS = 0xA
                RENDER_PRIM_COMPUTE_SHADER = 0xB
                RENDER_PRIM_TRIANGLE_STRIP = 0x7
                RENDER_PRIM_INSTANCED_QUADS = 0x9
                RENDER_PRIM_LINES_WITH_ADJACENCY = 0x2
                RENDER_PRIM_TRIANGLES_WITH_ADJACENCY = 0x6
                RENDER_PRIM_LINE_STRIP_WITH_ADJACENCY = 0x4
                RENDER_PRIM_TRIANGLE_STRIP_WITH_ADJACENCY = 0x8
            class InputLayoutVariation_t:
                INPUT_LAYOUT_VARIATION_MAX = 0x3
                INPUT_LAYOUT_VARIATION_DEFAULT = 0x0
                INPUT_LAYOUT_VARIATION_STREAM1_INSTANCEID = 0x1
                INPUT_LAYOUT_VARIATION_STREAM1_INSTANCEID_MORPH_VERT_ID = 0x2
            class RenderMultisampleType_t:
                RENDER_MULTISAMPLE_2X = 0x1
                RENDER_MULTISAMPLE_4X = 0x2
                RENDER_MULTISAMPLE_6X = 0x3
                RENDER_MULTISAMPLE_8X = 0x4
                RENDER_MULTISAMPLE_16X = 0x5
                RENDER_MULTISAMPLE_NONE = 0x0
                RENDER_MULTISAMPLE_INVALID = -0x1
                RENDER_MULTISAMPLE_TYPE_COUNT = 0x6
