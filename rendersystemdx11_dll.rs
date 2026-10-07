#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod rendersystemdx11_dll {
            pub mod RsBlendStateDesc_t {
                pub const m_blendOpBits: i64 = 0x0;
                pub const m_srcBlendBits: i64 = 0x0;
                pub const m_destBlendBits: i64 = 0x4;
                pub const m_blendEnableBits: i64 = 0x1C;
                pub const m_blendOpAlphaBits: i64 = 0x18;
                pub const m_srcBlendAlphaBits: i64 = 0x8;
                pub const m_destBlendAlphaBits: i64 = 0xC;
                pub const m_srgbWriteEnableBits: i64 = 0x1D;
                pub const m_bAlphaToCoverageEnable: i64 = 0x0;
                pub const m_bIndependentBlendEnable: i64 = 0x0;
                pub const m_renderTargetWriteMaskBits: i64 = 0x10;
            }
            pub mod VsInputSignature_t {
                pub const m_elems: i64 = 0x0;
                pub const m_depth_elems: i64 = 0x18;
            }
            pub mod RsStencilStateDesc_t {
                pub const m_bStencilEnable: i64 = 0x0;
                pub const m_backStencilFunc: i64 = 0x0;
                pub const m_frontStencilFunc: i64 = 0x0;
                pub const m_nStencilReadMask: i64 = 0x4;
                pub const m_backStencilFailOp: i64 = 0x0;
                pub const m_backStencilPassOp: i64 = 0x0;
                pub const m_nStencilWriteMask: i64 = 0x5;
                pub const m_frontStencilFailOp: i64 = 0x0;
                pub const m_frontStencilPassOp: i64 = 0x0;
                pub const m_backStencilDepthFailOp: i64 = 0x0;
                pub const m_frontStencilDepthFailOp: i64 = 0x0;
            }
            pub mod RsRasterizerStateDesc_t {
                pub const m_nCullMode: i64 = 0x1;
                pub const m_nFillMode: i64 = 0x0;
                pub const m_nDepthBias: i64 = 0x4;
                pub const m_bDepthClipEnable: i64 = 0x2;
                pub const m_flDepthBiasClamp: i64 = 0x8;
                pub const m_bMultisampleEnable: i64 = 0x3;
                pub const m_flSlopeScaledDepthBias: i64 = 0xC;
            }
            pub mod RenderInputLayoutField_t {
                pub const m_nSlot: i64 = 0x2A;
                pub const m_nOffset: i64 = 0x28;
                pub const m_nSlotType: i64 = 0x2B;
                pub const m_pSemanticName: i64 = 0x0;
                pub const m_nSemanticIndex: i64 = 0x20;
                pub const m_szShaderSemantic: i64 = 0x2C;
            }
            pub mod SheetSequenceIntegerId_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod RsDepthStencilStateDesc_t {
                pub const m_depthFunc: i64 = 0x0;
                pub const m_stencilState: i64 = 0x2;
                pub const m_bDepthTestEnable: i64 = 0x0;
                pub const m_bDepthWriteEnable: i64 = 0x0;
            }
            pub mod VsInputSignatureElement_t {
                pub const m_pName: i64 = 0x0;
                pub const m_pSemantic: i64 = 0x40;
                pub const m_pD3DSemanticName: i64 = 0x80;
                pub const m_nD3DSemanticIndex: i64 = 0xC0;
            }
            pub mod RsCullMode_t {
                pub const RS_CULL_BACK: i64 = 0x1;
                pub const RS_CULL_NONE: i64 = 0x0;
                pub const RS_CULL_FRONT: i64 = 0x2;
            }
            pub mod RsFillMode_t {
                pub const RS_FILL_SOLID: i64 = 0x0;
                pub const RS_FILL_WIREFRAME: i64 = 0x1;
            }
            pub mod RsComparison_t {
                pub const RS_CMP_LESS: i64 = 0x1;
                pub const RS_CMP_EQUAL: i64 = 0x2;
                pub const RS_CMP_NEVER: i64 = 0x0;
                pub const RS_CMP_ALWAYS: i64 = 0x7;
                pub const RS_CMP_CLOSER: i64 = 0x9;
                pub const RS_CMP_FARTHER: i64 = 0xC;
                pub const RS_CMP_GREATER: i64 = 0x4;
                pub const RS_CMP_FUNC_MASK: i64 = 0x7;
                pub const RS_CMP_NOT_EQUAL: i64 = 0x5;
                pub const RS_CMP_LESS_EQUAL: i64 = 0x3;
                pub const RS_CMP_CLOSER_EQUAL: i64 = 0xB;
                pub const RS_CMP_FARTHER_EQUAL: i64 = 0xE;
                pub const RS_CMP_GREATER_EQUAL: i64 = 0x6;
                pub const RS_CMP_CLOSER_FARTHER_FLAG: i64 = 0x8;
            }
            pub mod UpscalerType_t {
                pub const UPSCALER_NONE: i64 = 0x0;
                pub const UPSCALER_COUNT: i64 = 0x5;
                pub const UPSCALER_AMD_FSR2: i64 = 0x1;
                pub const UPSCALER_AMD_FSR3: i64 = 0x2;
                pub const UPSCALER_INTEL_XESS: i64 = 0x4;
                pub const UPSCALER_NVIDIA_DLSS: i64 = 0x3;
            }
            pub mod RenderSlotType_t {
                pub const RENDER_SLOT_INVALID: i64 = -0x1;
                pub const RENDER_SLOT_PER_VERTEX: i64 = 0x0;
                pub const RENDER_SLOT_PER_INSTANCE: i64 = 0x1;
            }
            pub mod RenderBufferFlags_t {
                pub const RENDER_BUFFER_USAGE_NONE: i64 = 0x0;
                pub const RENDER_BUFFER_POOL_ALLOCATED: i64 = 0x800;
                pub const RENDER_BUFFER_DYNAMIC_ZERO_COPY: i64 = 0x4000;
                pub const RENDER_BUFFER_STRUCTURED_BUFFER: i64 = 0x20;
                pub const RENDER_BUFFER_BYTEADDRESS_BUFFER: i64 = 0x10;
                pub const RENDER_BUFFER_USAGE_INDEX_BUFFER: i64 = 0x2;
                pub const RENDER_BUFFER_USAGE_VERTEX_BUFFER: i64 = 0x1;
                pub const RENDER_BUFFER_IMMOVABLE_ALLOCATION: i64 = 0x2000;
                pub const RENDER_BUFFER_SHADER_BINDING_TABLE: i64 = 0x400;
                pub const RENDER_BUFFER_USAGE_SHADER_RESOURCE: i64 = 0x4;
                pub const RENDER_BUFFER_ACCELERATION_STRUCTURE: i64 = 0x200;
                pub const RENDER_BUFFER_UAV_DRAW_INDIRECT_ARGS: i64 = 0x100;
                pub const RENDER_BUFFER_USAGE_UNORDERED_ACCESS: i64 = 0x8;
                pub const RENDER_BUFFER_USAGE_CONDITIONAL_RENDERING: i64 = 0x1000;
            }
            pub mod RenderPrimitiveType_t {
                pub const RENDER_PRIM_LINES: i64 = 0x1;
                pub const RENDER_PRIM_POINTS: i64 = 0x0;
                pub const RENDER_PRIM_TRIANGLES: i64 = 0x5;
                pub const RENDER_PRIM_LINE_STRIP: i64 = 0x3;
                pub const RENDER_PRIM_TYPE_COUNT: i64 = 0xD;
                pub const RENDER_PRIM_MESH_SHADER: i64 = 0xC;
                pub const RENDER_PRIM_HETEROGENOUS: i64 = 0xA;
                pub const RENDER_PRIM_COMPUTE_SHADER: i64 = 0xB;
                pub const RENDER_PRIM_TRIANGLE_STRIP: i64 = 0x7;
                pub const RENDER_PRIM_INSTANCED_QUADS: i64 = 0x9;
                pub const RENDER_PRIM_LINES_WITH_ADJACENCY: i64 = 0x2;
                pub const RENDER_PRIM_TRIANGLES_WITH_ADJACENCY: i64 = 0x6;
                pub const RENDER_PRIM_LINE_STRIP_WITH_ADJACENCY: i64 = 0x4;
                pub const RENDER_PRIM_TRIANGLE_STRIP_WITH_ADJACENCY: i64 = 0x8;
            }
            pub mod InputLayoutVariation_t {
                pub const INPUT_LAYOUT_VARIATION_MAX: i64 = 0x3;
                pub const INPUT_LAYOUT_VARIATION_DEFAULT: i64 = 0x0;
                pub const INPUT_LAYOUT_VARIATION_STREAM1_INSTANCEID: i64 = 0x1;
                pub const INPUT_LAYOUT_VARIATION_STREAM1_INSTANCEID_MORPH_VERT_ID: i64 = 0x2;
            }
            pub mod RenderMultisampleType_t {
                pub const RENDER_MULTISAMPLE_2X: i64 = 0x1;
                pub const RENDER_MULTISAMPLE_4X: i64 = 0x2;
                pub const RENDER_MULTISAMPLE_6X: i64 = 0x3;
                pub const RENDER_MULTISAMPLE_8X: i64 = 0x4;
                pub const RENDER_MULTISAMPLE_16X: i64 = 0x5;
                pub const RENDER_MULTISAMPLE_NONE: i64 = 0x0;
                pub const RENDER_MULTISAMPLE_INVALID: i64 = -0x1;
                pub const RENDER_MULTISAMPLE_TYPE_COUNT: i64 = 0x6;
            }
        }
    }
}
