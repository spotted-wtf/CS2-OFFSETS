export namespace cs2_dumper {
    export namespace schemas {
        export namespace panorama_dll {
            export namespace EStyleNodeType {
                export const ROOT = 0x0;
                export const DEFINE = 0x3;
                export const IMPORT = 0x4;
                export const PROPERTY = 0x2;
                export const KEYFRAMES = 0x5;
                export const EXPRESSION = 0x1;
                export const WHITESPACE = 0x8;
                export const EXPRESSION_URL = 0xA;
                export const STYLE_SELECTOR = 0x7;
                export const EXPRESSION_TEXT = 0x9;
                export const REFERENCE_PANEL = 0xF;
                export const EXPRESSION_CONCAT = 0xB;
                export const KEYFRAME_SELECTOR = 0x6;
                export const REFERENCE_CONTENT = 0xC;
                export const REFERENCE_COMPILED = 0xD;
                export const COMPILER_CONDITIONAL = 0x10;
                export const REFERENCE_PASSTHROUGH = 0xE;
            }
            export namespace ELayoutNodeType {
                export const ROOT = 0x0;
                export const PANEL = 0x7;
                export const STYLES = 0x1;
                export const INCLUDE = 0x5;
                export const SCRIPTS = 0x3;
                export const SNIPPET = 0x6;
                export const SNIPPETS = 0x4;
                export const SCRIPT_BODY = 0x2;
                export const PANEL_ATTRIBUTE = 0x8;
                export const REFERENCE_CONTENT = 0xA;
                export const REFERENCE_COMPILED = 0xB;
                export const PANEL_ATTRIBUTE_VALUE = 0x9;
                export const REFERENCE_PASSTHROUGH = 0xC;
            }
        }
    }
}
