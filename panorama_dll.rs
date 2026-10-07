#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod panorama_dll {
            pub mod EStyleNodeType {
                pub const ROOT: i64 = 0x0;
                pub const DEFINE: i64 = 0x3;
                pub const IMPORT: i64 = 0x4;
                pub const PROPERTY: i64 = 0x2;
                pub const KEYFRAMES: i64 = 0x5;
                pub const EXPRESSION: i64 = 0x1;
                pub const WHITESPACE: i64 = 0x8;
                pub const EXPRESSION_URL: i64 = 0xA;
                pub const STYLE_SELECTOR: i64 = 0x7;
                pub const EXPRESSION_TEXT: i64 = 0x9;
                pub const REFERENCE_PANEL: i64 = 0xF;
                pub const EXPRESSION_CONCAT: i64 = 0xB;
                pub const KEYFRAME_SELECTOR: i64 = 0x6;
                pub const REFERENCE_CONTENT: i64 = 0xC;
                pub const REFERENCE_COMPILED: i64 = 0xD;
                pub const COMPILER_CONDITIONAL: i64 = 0x10;
                pub const REFERENCE_PASSTHROUGH: i64 = 0xE;
            }
            pub mod ELayoutNodeType {
                pub const ROOT: i64 = 0x0;
                pub const PANEL: i64 = 0x7;
                pub const STYLES: i64 = 0x1;
                pub const INCLUDE: i64 = 0x5;
                pub const SCRIPTS: i64 = 0x3;
                pub const SNIPPET: i64 = 0x6;
                pub const SNIPPETS: i64 = 0x4;
                pub const SCRIPT_BODY: i64 = 0x2;
                pub const PANEL_ATTRIBUTE: i64 = 0x8;
                pub const REFERENCE_CONTENT: i64 = 0xA;
                pub const REFERENCE_COMPILED: i64 = 0xB;
                pub const PANEL_ATTRIBUTE_VALUE: i64 = 0x9;
                pub const REFERENCE_PASSTHROUGH: i64 = 0xC;
            }
        }
    }
}
