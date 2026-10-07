#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod soundsystem_dll {
            pub mod CSubmix {

            }
            pub mod CVSound {
                pub const m_nRate: i64 = 0x10;
                pub const m_nFormat: i64 = 0x14;
                pub const m_nLoopEnd: i64 = 0x2C;
                pub const m_Sentences: i64 = 0x0;
                pub const m_nChannels: i64 = 0x18;
                pub const m_flDuration: i64 = 0x24;
                pub const m_nLoopStart: i64 = 0x1C;
                pub const m_nSampleCount: i64 = 0x20;
                pub const m_nStreamingSize: i64 = 0x28;
            }
            pub mod CVMixHeap {
                pub const m_storage: i64 = 0x0;
            }
            pub mod KeyGroup_t {
                pub const nMaxNote: i64 = 0x2;
                pub const nMinNote: i64 = 0x1;
                pub const nCenterNote: i64 = 0x0;
                pub const pVelocityZones: i64 = 0x8;
                pub const nNumVelocityZones: i64 = 0x3;
            }
            pub mod CVMixSubmix {
                pub const m_name: i64 = 0x0;
                pub const m_SendNames: i64 = 0x8;
                pub const m_nChannels: i64 = 0x30;
                pub const m_nMixDownRule: i64 = 0x36;
                pub const m_nSendOperator: i64 = 0x34;
                pub const m_nSoloNameHash: i64 = 0x2C;
            }
            pub mod CVMixCommand {
                pub const m_nCommand: i64 = 0x0;
                pub const m_nProcessor: i64 = 0x14;
                pub const m_nInputValue0: i64 = 0x18;
                pub const m_nInputValue1: i64 = 0x1C;
                pub const m_nInputSubmix0: i64 = 0xC;
                pub const m_nInputSubmix1: i64 = 0x10;
                pub const m_nOutputSubmix: i64 = 0x8;
                pub const m_nParameterNameHash: i64 = 0x4;
            }
            pub mod CSndBeatTrack {
                pub const m_name: i64 = 0x0;
                pub const m_flBPM: i64 = 0x2C;
                pub const m_nTranspose: i64 = 0x24;
                pub const m_bSyncToVoice: i64 = 0x28;
                pub const m_playbackType: i64 = 0x20;
            }
            pub mod VMixEQ8Desc_t {
                pub const m_stages: i64 = 0x0;
            }
            pub mod VMixOscDesc_t {
                pub const m_freq: i64 = 0x4;
                pub const oscType: i64 = 0x0;
                pub const m_flPhase: i64 = 0x8;
            }
            pub mod CAudioSentence {
                pub const m_morphData: i64 = 0x38;
                pub const m_EmphasisSamples: i64 = 0x20;
                pub const m_RunTimePhonemes: i64 = 0x8;
                pub const m_bShouldVoiceDuck: i64 = 0x0;
            }
            pub mod CVMixInputBase {
                pub const m_name: i64 = 0x0;
            }
            pub mod CVMixVsndInput {
                pub const m_defaultValue: i64 = 0x0;
            }
            pub mod SamplerVoice_t {
                pub const nNoteNum: i64 = 0x0;
            }
            pub mod VelocityZone_t {
                pub const nMaxVel: i64 = 0x0;
                pub const pSamples: i64 = 0x4;
                pub const nNumSamples: i64 = 0x2;
                pub const nNextSelection: i64 = 0x1;
            }
            pub mod CAudioMorphData {
                pub const m_times: i64 = 0x0;
                pub const m_samples: i64 = 0x48;
                pub const m_flEaseIn: i64 = 0x60;
                pub const m_flEaseOut: i64 = 0x64;
                pub const m_nameStrings: i64 = 0x30;
                pub const m_nameHashCodes: i64 = 0x18;
            }
            pub mod CSndBeatPattern {
                pub const m_name: i64 = 0x0;
                pub const m_bLooping: i64 = 0x24;
                pub const m_flLength: i64 = 0x20;
                pub const m_syncType: i64 = 0x14;
                pub const m_playKeyType: i64 = 0x30;
                pub const m_playEventType: i64 = 0x28;
                pub const m_syncEventType: i64 = 0x98;
                pub const m_syncStartType: i64 = 0x10;
                pub const m_timeSignature: i64 = 0x18;
                pub const m_flPlayBeatMult: i64 = 0x2C;
                pub const m_flSyncBeatMult: i64 = 0x9C;
                pub const m_flSyncPriority: i64 = 0xC;
                pub const m_vecPatternKeys: i64 = 0x38;
                pub const m_vecPatternMidi: i64 = 0x80;
                pub const m_vecPatternFloats: i64 = 0x50;
                pub const m_vecPatternSndEvts: i64 = 0x68;
                pub const m_vecSyncPatternKeys: i64 = 0xA0;
            }
            pub mod CVMixAudioMeter {
                pub const m_name: i64 = 0x0;
                pub const m_nDebugId: i64 = 0x10;
                pub const m_displayName: i64 = 0x8;
            }
            pub mod CVMixDataOffset {
                pub const m_nOffset: i64 = 0x0;
            }
            pub mod CVMixGraphInput {
                pub const m_nOffset: i64 = 0x10;
            }
            pub mod VMixDelayDesc_t {
                pub const m_flDelay: i64 = 0x14;
                pub const m_flWidth: i64 = 0x24;
                pub const m_flDelayGain: i64 = 0x1C;
                pub const m_flDirectGain: i64 = 0x18;
                pub const m_bEnableFilter: i64 = 0x10;
                pub const m_feedbackFilter: i64 = 0x0;
                pub const m_flFeedbackGain: i64 = 0x20;
            }
            pub mod CAudioPhonemeTag {
                pub const m_flEndTime: i64 = 0x4;
                pub const m_flStartTime: i64 = 0x0;
                pub const m_nPhonemeCode: i64 = 0x8;
            }
            pub mod CSoundInfoHeader {

            }
            pub mod CVMixDescription {
                pub const m_sources: i64 = 0xE0;
                pub const m_submixList: i64 = 0xD0;
                pub const m_nNameHashCode: i64 = 0x100;
                pub const m_impulseResponseValues: i64 = 0xF0;
            }
            pub mod CVsndTriggerSlot {
                pub const m_mode: i64 = 0x80;
                pub const m_vsnd: i64 = 0x8;
                pub const m_volume: i64 = 0x78;
                pub const m_fadeOut: i64 = 0x7C;
                pub const m_endcapVsnd: i64 = 0x30;
                pub const m_bEnableVsnd: i64 = 0x0;
                pub const m_loopcapVsnd: i64 = 0x58;
                pub const m_bEnableEndcap: i64 = 0x28;
                pub const m_bEnableLoopcap: i64 = 0x50;
            }
            pub mod VMixFilterDesc_t {
                pub const m_flQ: i64 = 0x8;
                pub const m_bEnabled: i64 = 0xE;
                pub const m_fldbGain: i64 = 0x0;
                pub const m_nFilterType: i64 = 0xC;
                pub const m_flCutoffFreq: i64 = 0x4;
                pub const m_nFilterSlope: i64 = 0xD;
            }
            pub mod VMixPannerDesc_t {
                pub const m_type: i64 = 0x0;
                pub const m_flStrength: i64 = 0x4;
            }
            pub mod VMixShaperDesc_t {
                pub const m_nShape: i64 = 0x0;
                pub const m_flWetMix: i64 = 0xC;
                pub const m_fldbDrive: i64 = 0x4;
                pub const m_fldbOutputGain: i64 = 0x8;
                pub const m_nOversampleFactor: i64 = 0x10;
            }
            pub mod CVMixControlInput {
                pub const m_flDefaultValue: i64 = 0x10;
            }
            pub mod CVMixControlMeter {
                pub const m_nValueIndex: i64 = 0x10;
            }
            pub mod CVMixRuntimeGraph {
                pub const m_fixups: i64 = 0x110;
                pub const m_sources: i64 = 0x100;
                pub const m_submixes: i64 = 0xD0;
                pub const m_inputDefaultValues: i64 = 0xF0;
                pub const m_impulseResponseValues: i64 = 0xE0;
            }
            pub mod SosEditItemInfo_t {
                pub const itemPos: i64 = 0x28;
                pub const itemName: i64 = 0x8;
                pub const itemType: i64 = 0x0;
                pub const itemKVString: i64 = 0x20;
                pub const itemTypeName: i64 = 0x10;
            }
            pub mod VMixBoxverbDesc_t {
                pub const m_flTaps: i64 = 0x4C;
                pub const m_flDepth: i64 = 0x34;
                pub const m_flWidth: i64 = 0x2C;
                pub const m_flHeight: i64 = 0x30;
                pub const m_bParallel: i64 = 0x18;
                pub const m_flModRate: i64 = 0x14;
                pub const m_flSizeMax: i64 = 0x0;
                pub const m_flSizeMin: i64 = 0x4;
                pub const m_filterType: i64 = 0x1C;
                pub const m_flModDepth: i64 = 0x10;
                pub const m_flDiffusion: i64 = 0xC;
                pub const m_flComplexity: i64 = 0x8;
                pub const m_flOutputGain: i64 = 0x48;
                pub const m_flFeedbackDepth: i64 = 0x44;
                pub const m_flFeedbackScale: i64 = 0x38;
                pub const m_flFeedbackWidth: i64 = 0x3C;
                pub const m_flFeedbackHeight: i64 = 0x40;
            }
            pub mod VMixFlangerDesc_t {
                pub const m_flDelay: i64 = 0x8;
                pub const m_flModRate: i64 = 0x18;
                pub const m_flModDepth: i64 = 0x1C;
                pub const m_flGlideTime: i64 = 0x4;
                pub const m_bPhaseInvert: i64 = 0x0;
                pub const m_flOutputGain: i64 = 0xC;
                pub const m_flFeedbackGain: i64 = 0x10;
                pub const m_flFeedforwardGain: i64 = 0x14;
                pub const m_bApplyAntialiasing: i64 = 0x20;
            }
            pub mod VMixUtilityDesc_t {
                pub const m_nOp: i64 = 0x0;
                pub const m_bBassMono: i64 = 0x10;
                pub const m_flBassFreq: i64 = 0x14;
                pub const m_flInputPan: i64 = 0x4;
                pub const m_fldbOutputGain: i64 = 0xC;
                pub const m_flOutputBalance: i64 = 0x8;
            }
            pub mod VMixVocoderDesc_t {
                pub const m_bPeakMode: i64 = 0x24;
                pub const m_nBandCount: i64 = 0x0;
                pub const m_nDebugBand: i64 = 0x20;
                pub const m_flBandwidth: i64 = 0x4;
                pub const m_fldBModGain: i64 = 0x8;
                pub const m_flAttackTimeMS: i64 = 0x18;
                pub const m_flFreqRangeEnd: i64 = 0x10;
                pub const m_flReleaseTimeMS: i64 = 0x1C;
                pub const m_flFreqRangeStart: i64 = 0xC;
                pub const m_fldBUnvoicedGain: i64 = 0x14;
            }
            pub mod CSndSeqInstruments {

            }
            pub mod CVMixControlOutput {
                pub const m_flDefaultValue: i64 = 0x10;
            }
            pub mod CVMixParameterBool {
                pub const m_offset: i64 = 0x0;
            }
            pub mod CVoiceContainerSet {
                pub const m_soundsToPlay: i64 = 0x70;
            }
            pub mod ISndSeqInstruments {

            }
            pub mod SndBeatEventKeys_t {
                pub const m_flKey: i64 = 0x8;
            }
            pub mod VMixDiffusorDesc_t {
                pub const m_flSize: i64 = 0x0;
                pub const m_flFeedback: i64 = 0x8;
                pub const m_flComplexity: i64 = 0x4;
                pub const m_flOutputGain: i64 = 0xC;
            }
            pub mod VMixDynamicsBand_t {
                pub const m_bSolo: i64 = 0x21;
                pub const m_bEnable: i64 = 0x20;
                pub const m_flRatioAbove: i64 = 0x14;
                pub const m_flRatioBelow: i64 = 0x10;
                pub const m_fldbGainInput: i64 = 0x0;
                pub const m_flAttackTimeMS: i64 = 0x18;
                pub const m_fldbGainOutput: i64 = 0x4;
                pub const m_flReleaseTimeMS: i64 = 0x1C;
                pub const m_fldbThresholdAbove: i64 = 0xC;
                pub const m_fldbThresholdBelow: i64 = 0x8;
            }
            pub mod VMixDynamicsDesc_t {
                pub const m_flRatio: i64 = 0x14;
                pub const m_flWetMix: i64 = 0x28;
                pub const m_fldbGain: i64 = 0x0;
                pub const m_bPeakMode: i64 = 0x2C;
                pub const m_flRMSTimeMS: i64 = 0x24;
                pub const m_fldbKneeWidth: i64 = 0x10;
                pub const m_flAttackTimeMS: i64 = 0x1C;
                pub const m_flLimiterRatio: i64 = 0x18;
                pub const m_flReleaseTimeMS: i64 = 0x20;
                pub const m_fldbLimiterThreshold: i64 = 0xC;
                pub const m_fldbNoiseGateThreshold: i64 = 0x4;
                pub const m_fldbCompressionThreshold: i64 = 0x8;
            }
            pub mod VMixEQFilterDesc_t {
                pub const m_nChannelSet: i64 = 0x10;
            }
            pub mod VMixEnvelopeDesc_t {
                pub const m_flHoldTimeMS: i64 = 0x4;
                pub const m_flAttackTimeMS: i64 = 0x0;
                pub const m_flReleaseTimeMS: i64 = 0x8;
            }
            pub mod VMixFreeverbDesc_t {
                pub const m_flDamp: i64 = 0x4;
                pub const m_flWidth: i64 = 0x8;
                pub const m_flRoomSize: i64 = 0x0;
                pub const m_flLateReflections: i64 = 0xC;
            }
            pub mod VMixModDelayDesc_t {
                pub const m_flDelay: i64 = 0x18;
                pub const m_flModRate: i64 = 0x24;
                pub const m_flModDepth: i64 = 0x28;
                pub const m_flGlideTime: i64 = 0x14;
                pub const m_bPhaseInvert: i64 = 0x10;
                pub const m_flOutputGain: i64 = 0x1C;
                pub const m_feedbackFilter: i64 = 0x0;
                pub const m_flFeedbackGain: i64 = 0x20;
                pub const m_bApplyAntialiasing: i64 = 0x2C;
            }
            pub mod CVMixNameInputMeter {
                pub const m_nValueIndex: i64 = 0x10;
            }
            pub mod CVMixParameterFloat {
                pub const m_offset: i64 = 0x0;
            }
            pub mod CVoiceContainerBase {
                pub const m_vSound: i64 = 0x28;
                pub const m_pEnvelopeAnalyzer: i64 = 0x68;
            }
            pub mod CVoiceContainerEnum {
                pub const m_iSelection: i64 = 0xA8;
                pub const m_soundsToPlay: i64 = 0x70;
                pub const m_flCrossfadeTime: i64 = 0xAC;
            }
            pub mod CVoiceContainerNull {

            }
            pub mod VMixPlateverbDesc_t {
                pub const m_flDamp: i64 = 0x10;
                pub const m_flDecay: i64 = 0xC;
                pub const m_flPrefilter: i64 = 0x0;
                pub const m_flInputDiffusion1: i64 = 0x4;
                pub const m_flInputDiffusion2: i64 = 0x8;
                pub const m_flFeedbackDiffusion1: i64 = 0x14;
                pub const m_flFeedbackDiffusion2: i64 = 0x18;
            }
            pub mod VMixPresetDSPDesc_t {
                pub const m_effectName: i64 = 0x0;
            }
            pub mod CAudioEmphasisSample {
                pub const m_flTime: i64 = 0x0;
                pub const m_flValue: i64 = 0x4;
            }
            pub mod CDSPMixgroupModifier {
                pub const m_mixgroup: i64 = 0x0;
                pub const m_flModifier: i64 = 0x8;
                pub const m_flModifierMin: i64 = 0xC;
                pub const m_flSourceModifier: i64 = 0x10;
                pub const m_flSourceModifierMin: i64 = 0x14;
                pub const m_flListenerReverbModifierWhenSourceReverbIsActive: i64 = 0x18;
            }
            pub mod CVsndRadioButtonSlot {
                pub const m_mode: i64 = 0x84;
                pub const m_vsnd: i64 = 0x8;
                pub const m_group: i64 = 0x78;
                pub const m_volume: i64 = 0x7C;
                pub const m_fadeOut: i64 = 0x80;
                pub const m_endcapVsnd: i64 = 0x30;
                pub const m_bEnableVsnd: i64 = 0x0;
                pub const m_loopcapVsnd: i64 = 0x58;
                pub const m_bEnableEndcap: i64 = 0x28;
                pub const m_bEnableLoopcap: i64 = 0x50;
            }
            pub mod VMixAutoFilterDesc_t {
                pub const m_filter: i64 = 0xC;
                pub const m_flPhase: i64 = 0x24;
                pub const m_flLFORate: i64 = 0x20;
                pub const m_nLFOShape: i64 = 0x28;
                pub const m_flLFOAmount: i64 = 0x1C;
                pub const m_flAttackTimeMS: i64 = 0x4;
                pub const m_flReleaseTimeMS: i64 = 0x8;
                pub const m_flEnvelopeAmount: i64 = 0x0;
            }
            pub mod VMixPitchShiftDesc_t {
                pub const m_nQuality: i64 = 0x8;
                pub const m_nProcType: i64 = 0xC;
                pub const m_flPitchShift: i64 = 0x4;
                pub const m_nGrainSampleCount: i64 = 0x0;
            }
            pub mod CRandomPannerControls {
                pub const m_flMaxVolume: i64 = 0x14;
                pub const m_flMinVolume: i64 = 0x10;
                pub const m_strVectorStackParam: i64 = 0x18;
                pub const m_volumeControlInputName: i64 = 0x8;
                pub const m_panningControlInputName: i64 = 0x0;
            }
            pub mod CSndSeqInstBaseSchema {
                pub const m_flBPM: i64 = 0x10;
                pub const m_nType: i64 = 0x8;
                pub const m_flBPMFactor: i64 = 0x14;
                pub const m_flBPMInvFactor: i64 = 0x18;
                pub const m_bStopCurrentEvents: i64 = 0xE;
            }
            pub mod CSosGroupActionSchema {

            }
            pub mod CVMixAdditionalOutput {
                pub const m_name: i64 = 0x0;
            }
            pub mod CVMixEQ8ProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramEQScale: i64 = 0xC8;
            }
            pub mod CVMixOscProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramPhase: i64 = 0x38;
                pub const m_paramFrequency: i64 = 0x34;
            }
            pub mod CVoiceContainerSwitch {
                pub const m_soundsToPlay: i64 = 0x70;
            }
            pub mod VMixConvolutionDesc_t {
                pub const m_fldbLow: i64 = 0xC;
                pub const m_fldbMid: i64 = 0x10;
                pub const m_flWetMix: i64 = 0x8;
                pub const m_fldbGain: i64 = 0x0;
                pub const m_fldbHigh: i64 = 0x14;
                pub const m_flPreDelayMS: i64 = 0x4;
                pub const m_flLowCutoffFreq: i64 = 0x18;
                pub const m_flHighCutoffFreq: i64 = 0x1C;
            }
            pub mod VMixEffectChainDesc_t {
                pub const m_effectName: i64 = 0x0;
            }
            pub mod CDspPresetModifierList {
                pub const m_dspName: i64 = 0x0;
                pub const m_modifiers: i64 = 0x8;
            }
            pub mod CSndBeatPatternManager {
                pub const m_vecPatterns: i64 = 0x38;
                pub const m_vecActiveTracks: i64 = 0x70;
            }
            pub mod CSndSeqInstMidiSampler {
                pub const m_flAttack: i64 = 0x2C;
                pub const m_nMaxNote: i64 = 0x23;
                pub const m_nMinNote: i64 = 0x22;
                pub const m_flRelease: i64 = 0x30;
                pub const m_bIsSoundEvent: i64 = 0x20;
                pub const m_bStopPrevious: i64 = 0x21;
                pub const m_bBeatEnvelopes: i64 = 0x34;
                pub const m_nNextVoiceSlot: i64 = 0xD4;
                pub const m_hSoundEventHash: i64 = 0xD8;
                pub const m_flMaxVelocityAtten: i64 = 0x28;
                pub const m_flMinVelocityAtten: i64 = 0x24;
            }
            pub mod CVMixBaseProcessorDesc {
                pub const m_name: i64 = 0x8;
                pub const m_flxfade: i64 = 0x14;
                pub const m_nDebugId: i64 = 0x10;
                pub const m_paramMix: i64 = 0x24;
                pub const m_nChannels: i64 = 0x18;
                pub const m_paramEnable: i64 = 0x20;
                pub const m_bDebugBypass: i64 = 0x1C;
            }
            pub mod CVoiceContainerBlender {
                pub const m_firstSound: i64 = 0x70;
                pub const m_secondSound: i64 = 0x90;
                pub const m_flBlendFactor: i64 = 0xB0;
            }
            pub mod CVoiceContainerDefault {

            }
            pub mod CVoiceContainerVMixSnd {

            }
            pub mod SelectedEditItemInfo_t {
                pub const m_EditItems: i64 = 0x0;
            }
            pub mod SndBeatTimeSignature_t {
                pub const nNumerator: i64 = 0x0;
                pub const nDenominator: i64 = 0x1;
            }
            pub mod CSndSeqInstSndEvtSchema {

            }
            pub mod CVMixDelayProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramDelay: i64 = 0x54;
                pub const m_paramCutoffFrequency: i64 = 0x50;
            }
            pub mod CVoiceContainerSelector {
                pub const m_mode: i64 = 0x70;
                pub const m_soundsToPlay: i64 = 0x78;
                pub const m_fProbabilityWeights: i64 = 0xB0;
            }
            pub mod VMixDynamics3BandDesc_t {
                pub const m_flDepth: i64 = 0xC;
                pub const m_bandDesc: i64 = 0x24;
                pub const m_flWetMix: i64 = 0x10;
                pub const m_bPeakMode: i64 = 0x20;
                pub const m_flRMSTimeMS: i64 = 0x4;
                pub const m_flTimeScale: i64 = 0x14;
                pub const m_fldbKneeWidth: i64 = 0x8;
                pub const m_fldbGainOutput: i64 = 0x0;
                pub const m_flLowCutoffFreq: i64 = 0x18;
                pub const m_flHighCutoffFreq: i64 = 0x1C;
            }
            pub mod VMixPointerFixupEntry_t {
                pub const m_nIndex: i64 = 0x0;
                pub const m_offset: i64 = 0x4;
            }
            pub mod CSoundContainerReference {
                pub const m_sound: i64 = 0x10;
                pub const m_pSound: i64 = 0x18;
                pub const m_namespace: i64 = 0x0;
                pub const m_bUseReference: i64 = 0x8;
            }
            pub mod CVMixFilterProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramQ: i64 = 0x3C;
                pub const m_paramCutoffFreq: i64 = 0x38;
            }
            pub mod CVMixPannerProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramPan: i64 = 0x30;
            }
            pub mod CVMixParameterEffectName {
                pub const m_offset: i64 = 0x0;
            }
            pub mod CVMixShaperProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramDrive: i64 = 0x3C;
            }
            pub mod CVoiceContainerGenerator {

            }
            pub mod CVoiceContainerLoopXFade {
                pub const m_sound: i64 = 0x70;
                pub const m_flFadeIn: i64 = 0x9C;
                pub const m_bEqualPow: i64 = 0xA2;
                pub const m_bPlayHead: i64 = 0xA0;
                pub const m_bPlayTail: i64 = 0xA1;
                pub const m_flFadeOut: i64 = 0x98;
                pub const m_flLoopEnd: i64 = 0x90;
                pub const m_flLoopStart: i64 = 0x94;
            }
            pub mod VMixDualCompressorDesc_t {
                pub const m_bandDesc: i64 = 0x10;
                pub const m_flWetMix: i64 = 0x8;
                pub const m_bPeakMode: i64 = 0xC;
                pub const m_flRMSTimeMS: i64 = 0x0;
                pub const m_fldbKneeWidth: i64 = 0x4;
            }
            pub mod VMixSubgraphSwitchDesc_t {
                pub const m_name: i64 = 0x0;
                pub const m_subgraphs: i64 = 0x10;
                pub const m_effectName: i64 = 0x8;
                pub const m_interpolationMode: i64 = 0x28;
                pub const m_bOnlyTailsOnFadeOut: i64 = 0x2C;
                pub const m_flInterpolationTime: i64 = 0x30;
            }
            pub mod CSosSoundEventGroupSchema {
                pub const m_flOpvar: i64 = 0x44;
                pub const m_vActions: i64 = 0x58;
                pub const m_flEntIndex: i64 = 0x3C;
                pub const m_nGroupType: i64 = 0x8;
                pub const m_opvarString: i64 = 0x50;
                pub const m_bInvertMatch: i64 = 0x18;
                pub const m_bBlocksEvents: i64 = 0xC;
                pub const m_Behavior_Opvar: i64 = 0x40;
                pub const m_nBlockMaxCount: i64 = 0x10;
                pub const m_Behavior_String: i64 = 0x48;
                pub const m_Behavior_EntIndex: i64 = 0x38;
                pub const m_Behavior_EventName: i64 = 0x1C;
                pub const m_matchSoundEventName: i64 = 0x20;
                pub const m_bMatchEventSubString: i64 = 0x28;
                pub const m_flMemberLifespanTime: i64 = 0x14;
                pub const m_matchSoundEventSubString: i64 = 0x30;
            }
            pub mod CVMixBaseGraphDescription {
                pub const m_heap: i64 = 0x70;
                pub const m_name: i64 = 0x0;
                pub const m_audioMeters: i64 = 0x80;
                pub const m_graphInputs: i64 = 0x20;
                pub const m_mixCommands: i64 = 0x60;
                pub const m_bIsMainGraph: i64 = 0xC;
                pub const m_controlMeters: i64 = 0x90;
                pub const m_controlOutputs: i64 = 0x40;
                pub const m_processorNodes: i64 = 0x10;
                pub const m_nameInputMeters: i64 = 0xA0;
                pub const m_additionalOutputs: i64 = 0xB0;
                pub const m_nGraphOutputChannels: i64 = 0x8;
                pub const m_impulseResponseInputs: i64 = 0x50;
                pub const m_automaticControlInputs: i64 = 0xC0;
                pub const m_controlTransientInputs: i64 = 0x30;
            }
            pub mod CVMixBoxverbProcessorDesc {
                pub const m_desc: i64 = 0x28;
            }
            pub mod CVMixFlangerProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramDelay: i64 = 0x4C;
                pub const m_paramModRate: i64 = 0x50;
                pub const m_paramModDepth: i64 = 0x54;
            }
            pub mod CVMixImpulseResponseInput {

            }
            pub mod CVMixUtilityProcessorDesc {
                pub const m_desc: i64 = 0x28;
            }
            pub mod CVMixVocoderProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramBandwidth: i64 = 0x50;
            }
            pub mod CVoiceContainerGranulator {
                pub const m_sourceAudio: i64 = 0x98;
                pub const m_flGrainLength: i64 = 0x80;
                pub const m_flStartJitter: i64 = 0x88;
                pub const m_flPlaybackJitter: i64 = 0x8C;
                pub const m_bShouldWraparound: i64 = 0x90;
                pub const m_flMaxSourceLength: i64 = 0xA4;
                pub const m_flGrainCrossfadeAmount: i64 = 0x84;
                pub const m_bDoubleBufferSourceAudio: i64 = 0xA0;
            }
            pub mod CVoiceContainerSetElement {
                pub const m_sound: i64 = 0x0;
                pub const m_flVolumeDB: i64 = 0x20;
            }
            pub mod CVoiceContainerTapePlayer {
                pub const m_sourceAudio: i64 = 0x88;
                pub const m_bShouldWraparound: i64 = 0x80;
                pub const m_flTapeSpeedAttackTime: i64 = 0x90;
                pub const m_flTapeSpeedReleaseTime: i64 = 0x94;
            }
            pub mod SndBeatEventKeyedFloats_t {
                pub const m_flFloat: i64 = 0x10;
            }
            pub mod CSosGroupActionLimitSchema {
                pub const m_nMaxCount: i64 = 0x8;
                pub const m_nSortType: i64 = 0x10;
                pub const m_nStopType: i64 = 0xC;
                pub const m_bCountStopped: i64 = 0x15;
                pub const m_bStopImmediate: i64 = 0x14;
            }
            pub mod CVMixAutomaticControlInput {
                pub const m_name: i64 = 0x0;
                pub const m_nControlType: i64 = 0x10;
                pub const m_nGraphInputIndex: i64 = 0xC;
            }
            pub mod CVMixBoxverb2ProcessorDesc {
                pub const m_desc: i64 = 0x28;
            }
            pub mod CVMixDiffusorProcessorDesc {
                pub const m_desc: i64 = 0x28;
            }
            pub mod CVMixDynamicsProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_outParamLevel: i64 = 0x58;
                pub const m_outParamdBLevel: i64 = 0x5C;
            }
            pub mod CVMixEnvelopeProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_outParamLevel: i64 = 0x34;
                pub const m_outParamdBLevel: i64 = 0x38;
            }
            pub mod CVMixFreeverbProcessorDesc {
                pub const m_desc: i64 = 0x28;
            }
            pub mod CVMixModDelayProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramDelay: i64 = 0x5C;
                pub const m_paramModRate: i64 = 0x60;
                pub const m_paramModDepth: i64 = 0x64;
                pub const m_paramCutoffFrequency: i64 = 0x58;
            }
            pub mod CVoiceContainerLoopTrigger {
                pub const m_sound: i64 = 0x80;
                pub const m_bCrossFade: i64 = 0x7C;
                pub const m_flFadeTime: i64 = 0x78;
                pub const m_flRetriggerTimeMax: i64 = 0x74;
                pub const m_flRetriggerTimeMin: i64 = 0x70;
            }
            pub mod CVoiceContainerShapedNoise {
                pub const m_gainSweep: i64 = 0x108;
                pub const m_flFrequency: i64 = 0x74;
                pub const m_flResonance: i64 = 0xBC;
                pub const m_frequencySweep: i64 = 0x78;
                pub const m_resonanceSweep: i64 = 0xC0;
                pub const m_flGainInDecibels: i64 = 0x104;
                pub const m_bUseCurveForAmplitude: i64 = 0x100;
                pub const m_bUseCurveForFrequency: i64 = 0x70;
                pub const m_bUseCurveForResonance: i64 = 0xB8;
            }
            pub mod CVoiceContainerVsndTrigger {
                pub const m_slot1: i64 = 0x78;
                pub const m_slot2: i64 = 0x100;
                pub const m_slot3: i64 = 0x188;
                pub const m_slot4: i64 = 0x210;
                pub const m_slot5: i64 = 0x298;
                pub const m_slot6: i64 = 0x320;
                pub const m_slot7: i64 = 0x3A8;
                pub const m_slot8: i64 = 0x430;
                pub const m_slot9: i64 = 0x4B8;
                pub const m_slot10: i64 = 0x540;
                pub const m_slot11: i64 = 0x5C8;
                pub const m_slot12: i64 = 0x650;
                pub const m_slot13: i64 = 0x6D8;
                pub const m_slot14: i64 = 0x760;
                pub const m_slot15: i64 = 0x7E8;
                pub const m_slot16: i64 = 0x870;
                pub const m_namespace: i64 = 0x70;
            }
            pub mod SndBeatEventKeyedSndEvts_t {
                pub const m_strSoundEventName: i64 = 0x10;
            }
            pub mod CVMixPresetDSPProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramEffectName: i64 = 0x38;
            }
            pub mod CVoiceContainerAnalysisBase {
                pub const m_curve: i64 = 0x8;
            }
            pub mod CVoiceContainerMultiBlender {
                pub const m_flCrossover: i64 = 0xAC;
                pub const m_soundsToPlay: i64 = 0x70;
                pub const m_flBlendFactor: i64 = 0xA8;
            }
            pub mod CVMixAutoFilterProcessorDesc {
                pub const m_desc: i64 = 0x28;
            }
            pub mod CVMixPitchShiftProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramPitchScale: i64 = 0x38;
            }
            pub mod CVoiceContainerRandomSampler {
                pub const m_flAmplitude: i64 = 0x80;
                pub const m_flMaxLength: i64 = 0x8C;
                pub const m_flTimeJitter: i64 = 0x88;
                pub const m_grainResources: i64 = 0x98;
                pub const m_flAmplitudeJitter: i64 = 0x84;
                pub const m_nNumDelayVariations: i64 = 0x90;
            }
            pub mod SndBeatEventKeyedMidiNotes_t {
                pub const m_nNote: i64 = 0x11;
                pub const m_nStatus: i64 = 0x10;
                pub const m_nVelocity: i64 = 0x12;
            }
            pub mod VMixDynamicsCompressorDesc_t {
                pub const m_flWetMix: i64 = 0x1C;
                pub const m_bPeakMode: i64 = 0x24;
                pub const m_flRMSTimeMS: i64 = 0x18;
                pub const m_fldbKneeWidth: i64 = 0x8;
                pub const m_flAttackTimeMS: i64 = 0x10;
                pub const m_fldbOutputGain: i64 = 0x0;
                pub const m_bAutoMakeupGain: i64 = 0x25;
                pub const m_flReleaseTimeMS: i64 = 0x14;
                pub const m_flSCHighPassFreq: i64 = 0x20;
                pub const m_flCompressionRatio: i64 = 0xC;
                pub const m_fldbCompressionThreshold: i64 = 0x4;
            }
            pub mod CSoundContainerReferenceArray {
                pub const m_sounds: i64 = 0x8;
                pub const m_pSounds: i64 = 0x20;
                pub const m_bUseReference: i64 = 0x0;
            }
            pub mod CVMixConvolutionProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramImpulseResponse: i64 = 0x48;
            }
            pub mod CVMixEffectChainProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramEffectName: i64 = 0x30;
            }
            pub mod CVMixPlateReverbProcessorDesc {
                pub const m_desc: i64 = 0x28;
            }
            pub mod CVMixStereoDelayProcessorDesc {
                pub const m_paramDelayLeft: i64 = 0x28;
                pub const m_paramDelayRight: i64 = 0x2C;
            }
            pub mod CVoiceContainerAsyncGenerator {

            }
            pub mod CSosGroupActionOcclusionSchema {
                pub const m_flRadius: i64 = 0xC;
                pub const m_flTestDepth: i64 = 0x1C;
                pub const m_flOcclusionMax: i64 = 0x18;
                pub const m_flOcclusionMin: i64 = 0x14;
                pub const m_flOcclusionScale: i64 = 0x10;
                pub const m_flCalculationInterval: i64 = 0x8;
            }
            pub mod CSosGroupActionTimeLimitSchema {
                pub const m_flMaxDuration: i64 = 0x8;
            }
            pub mod CVoiceContainerVsndRadioButton {
                pub const m_slot1: i64 = 0x78;
                pub const m_slot2: i64 = 0x100;
                pub const m_slot3: i64 = 0x188;
                pub const m_slot4: i64 = 0x210;
                pub const m_slot5: i64 = 0x298;
                pub const m_slot6: i64 = 0x320;
                pub const m_slot7: i64 = 0x3A8;
                pub const m_slot8: i64 = 0x430;
                pub const m_slot9: i64 = 0x4B8;
                pub const m_slot10: i64 = 0x540;
                pub const m_slot11: i64 = 0x5C8;
                pub const m_slot12: i64 = 0x650;
                pub const m_slot13: i64 = 0x6D8;
                pub const m_slot14: i64 = 0x760;
                pub const m_slot15: i64 = 0x7E8;
                pub const m_slot16: i64 = 0x870;
                pub const m_namespace: i64 = 0x70;
            }
            pub mod CDSPPresetMixgroupModifierTable {
                pub const m_table: i64 = 0x0;
            }
            pub mod CVMixDynamics3BandProcessorDesc {
                pub const m_desc: i64 = 0x28;
            }
            pub mod CVoiceContainerDecayingSineWave {
                pub const m_flDecayTime: i64 = 0x74;
                pub const m_flFrequency: i64 = 0x70;
            }
            pub mod CVoiceContainerEnvelopeAnalyzer {
                pub const m_mode: i64 = 0x48;
                pub const m_flThreshold: i64 = 0x50;
                pub const m_fAnalysisWindowMs: i64 = 0x4C;
            }
            pub mod CVoiceContainerParameterBlender {
                pub const m_curve1: i64 = 0xB8;
                pub const m_curve2: i64 = 0xF8;
                pub const m_curve3: i64 = 0x140;
                pub const m_curve4: i64 = 0x180;
                pub const m_firstSound: i64 = 0x70;
                pub const m_secondSound: i64 = 0x90;
                pub const m_bEnableDistanceBlend: i64 = 0x138;
                pub const m_bEnableOcclusionBlend: i64 = 0xB0;
            }
            pub mod CVMixDualCompressorProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_outParamLevel: i64 = 0x5C;
                pub const m_outParamdBLevel: i64 = 0x60;
                pub const m_outParamReduction: i64 = 0x64;
            }
            pub mod CVMixSteamAudioHRTFProcessorDesc {
                pub const m_paramDelayLeft: i64 = 0x44;
                pub const m_paramPositionX: i64 = 0x28;
                pub const m_paramPositionY: i64 = 0x2C;
                pub const m_paramPositionZ: i64 = 0x30;
                pub const m_paramDelayRight: i64 = 0x48;
                pub const m_paramInterpolation: i64 = 0x34;
                pub const m_paramDirectMixLevel: i64 = 0x38;
                pub const m_paramRelativePosition: i64 = 0x40;
                pub const m_paramPerspectiveCorrection: i64 = 0x3C;
            }
            pub mod CVMixSubgraphSwitchProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_paramEffectName: i64 = 0x60;
                pub const m_paramSelectionIndex: i64 = 0x64;
            }
            pub mod CVoiceContainerRealtimeFMSineWave {
                pub const m_flModulatorAmount: i64 = 0x78;
                pub const m_flCarrierFrequency: i64 = 0x70;
                pub const m_flModulatorFrequency: i64 = 0x74;
            }
            pub mod CVMixSteamAudioDirectProcessorDesc {
                pub const m_paramUpX: i64 = 0x40;
                pub const m_paramUpY: i64 = 0x44;
                pub const m_paramUpZ: i64 = 0x48;
                pub const m_paramBand: i64 = 0x84;
                pub const m_paramAheadX: i64 = 0x4C;
                pub const m_paramAheadY: i64 = 0x50;
                pub const m_paramAheadZ: i64 = 0x54;
                pub const m_paramRightX: i64 = 0x34;
                pub const m_paramRightY: i64 = 0x38;
                pub const m_paramRightZ: i64 = 0x3C;
                pub const m_paramOcclusion: i64 = 0x74;
                pub const m_paramPositionX: i64 = 0x28;
                pub const m_paramPositionY: i64 = 0x2C;
                pub const m_paramPositionZ: i64 = 0x30;
                pub const m_paramDipolePower: i64 = 0x70;
                pub const m_paramDipoleWeight: i64 = 0x6C;
                pub const m_paramTransmission: i64 = 0x88;
                pub const m_paramApplyOcclusion: i64 = 0x64;
                pub const m_paramTransmissionLow: i64 = 0x78;
                pub const m_paramTransmissionMid: i64 = 0x7C;
                pub const m_paramApplyDirectivity: i64 = 0x60;
                pub const m_paramTransmissionHigh: i64 = 0x80;
                pub const m_paramApplyTransmission: i64 = 0x68;
                pub const m_paramApplyAirAbsorption: i64 = 0x5C;
                pub const m_paramApplyDistanceAttenuation: i64 = 0x58;
            }
            pub mod CVoiceContainerStaticAdditiveSynth {
                pub const m_tones: i64 = 0x80;
            }
            pub mod CSosGroupActionTimeBlockLimitSchema {
                pub const m_nMaxCount: i64 = 0x8;
                pub const m_flMaxDuration: i64 = 0xC;
            }
            pub mod CVMixSteamAudioPathingProcessorDesc {
                pub const m_paramBand: i64 = 0x38;
                pub const m_paramPositionX: i64 = 0x28;
                pub const m_paramPositionY: i64 = 0x2C;
                pub const m_paramPositionZ: i64 = 0x30;
                pub const m_paramArrayPathingEQ: i64 = 0x3C;
                pub const m_paramPathingMixLevel: i64 = 0x34;
                pub const m_paramArrayPathingCoefficients: i64 = 0x40;
            }
            pub mod CSosGroupActionSoundeventCountSchema {
                pub const m_strCountKeyName: i64 = 0x10;
                pub const m_bExcludeStoppedSounds: i64 = 0x8;
            }
            pub mod CVMixDynamicsCompressorProcessorDesc {
                pub const m_desc: i64 = 0x28;
                pub const m_outParamLevel: i64 = 0x50;
                pub const m_outParamdBLevel: i64 = 0x54;
                pub const m_outParamReduction: i64 = 0x58;
            }
            pub mod CVoiceContainerAmpedDecayingSineWave {
                pub const m_flGainAmount: i64 = 0x78;
            }
            pub mod CSosGroupActionSoundeventClusterSchema {
                pub const m_nMinNearby: i64 = 0x8;
                pub const m_shouldPlayOpvar: i64 = 0x10;
                pub const m_clusterSizeOpvar: i64 = 0x20;
                pub const m_flClusterEpsilon: i64 = 0xC;
                pub const m_shouldPlayClusterChild: i64 = 0x18;
                pub const m_groupBoundingBoxMaxsOpvar: i64 = 0x30;
                pub const m_groupBoundingBoxMinsOpvar: i64 = 0x28;
            }
            pub mod CSosGroupActionSoundeventPrioritySchema {
                pub const m_priorityValue: i64 = 0x8;
                pub const m_priorityVolumeScalar: i64 = 0x10;
                pub const m_priorityContributeButDontRead: i64 = 0x18;
                pub const m_bPriorityReadButDontContribute: i64 = 0x20;
            }
            pub mod CSosGroupActionMemberCountEnvelopeSchema {
                pub const m_flDecay: i64 = 0x1C;
                pub const m_flAttack: i64 = 0x18;
                pub const m_nBaseCount: i64 = 0x8;
                pub const m_flBaseValue: i64 = 0x10;
                pub const m_bSaveToGroup: i64 = 0x28;
                pub const m_nTargetCount: i64 = 0xC;
                pub const m_flTargetValue: i64 = 0x14;
                pub const m_resultVarName: i64 = 0x20;
            }
            pub mod CVMixSteamAudioHybridReverbProcessorDesc {
                pub const m_paramBand: i64 = 0x34;
                pub const m_paramReverbTime: i64 = 0x38;
                pub const m_paramReverbTimeLow: i64 = 0x28;
                pub const m_paramReverbTimeMid: i64 = 0x2C;
                pub const m_paramReverbTimeHigh: i64 = 0x30;
            }
            pub mod CVoiceContainerStaticAdditiveSynth__CTone {
                pub const m_curve: i64 = 0x18;
                pub const m_harmonics: i64 = 0x0;
                pub const m_bSyncInstances: i64 = 0x58;
            }
            pub mod CVoiceContainerLoopTriggerWithRandomPanner {
                pub const m_randomPannerControls: i64 = 0xA0;
            }
            pub mod CSosGroupActionSetSoundeventParameterSchema {
                pub const m_nMaxCount: i64 = 0x8;
                pub const m_nSortType: i64 = 0x20;
                pub const m_opvarName: i64 = 0x18;
                pub const m_flMaxValue: i64 = 0x10;
                pub const m_flMinValue: i64 = 0xC;
            }
            pub mod CSosGroupActionSoundeventMinMaxValuesSchema {
                pub const m_strMaxValueName: i64 = 0x30;
                pub const m_strMinValueName: i64 = 0x28;
                pub const m_bExcludeDelayedSounds: i64 = 0x19;
                pub const m_bExcludeStoppedSounds: i64 = 0x18;
                pub const m_strDelayPublicFieldName: i64 = 0x10;
                pub const m_strQueryPublicFieldName: i64 = 0x8;
                pub const m_bExcludSoundsAboveThreshold: i64 = 0x20;
                pub const m_bExcludeSoundsBelowThreshold: i64 = 0x1A;
                pub const m_flExcludeSoundsMaxThresholdValue: i64 = 0x24;
                pub const m_flExcludeSoundsMinThresholdValue: i64 = 0x1C;
            }
            pub mod CVoiceContainerStaticAdditiveSynth__CHarmonic {
                pub const m_curve: i64 = 0x10;
                pub const m_flCents: i64 = 0x8;
                pub const m_flPhase: i64 = 0xC;
                pub const m_nOctave: i64 = 0x4;
                pub const m_nWaveform: i64 = 0x0;
                pub const m_nFundamental: i64 = 0x1;
                pub const m_volumeScaling: i64 = 0x50;
            }
            pub mod CVoiceContainerStaticAdditiveSynth__CGainScalePerInstance {
                pub const m_flMaxVolume: i64 = 0x8;
                pub const m_flMinVolume: i64 = 0x0;
                pub const m_nInstancesAtMaxVolume: i64 = 0xC;
                pub const m_nInstancesAtMinVolume: i64 = 0x4;
            }
            pub mod EMode_t {
                pub const RMS: i64 = 0x1;
                pub const Peak: i64 = 0x0;
            }
            pub mod EMidiNote {
                pub const A: i64 = 0x9;
                pub const B: i64 = 0xB;
                pub const C: i64 = 0x0;
                pub const D: i64 = 0x2;
                pub const E: i64 = 0x4;
                pub const F: i64 = 0x5;
                pub const G: i64 = 0x7;
                pub const Count: i64 = 0xC;
                pub const A_Sharp: i64 = 0xA;
                pub const C_Sharp: i64 = 0x1;
                pub const D_Sharp: i64 = 0x3;
                pub const F_Sharp: i64 = 0x6;
                pub const G_Sharp: i64 = 0x8;
            }
            pub mod EWaveform {
                pub const Saw: i64 = 0x2;
                pub const Sine: i64 = 0x0;
                pub const Noise: i64 = 0x4;
                pub const Square: i64 = 0x1;
                pub const Triangle: i64 = 0x3;
            }
            pub mod soundlevel_t {
                pub const SNDLVL_20dB: i64 = 0x14;
                pub const SNDLVL_25dB: i64 = 0x19;
                pub const SNDLVL_30dB: i64 = 0x1E;
                pub const SNDLVL_35dB: i64 = 0x23;
                pub const SNDLVL_40dB: i64 = 0x28;
                pub const SNDLVL_45dB: i64 = 0x2D;
                pub const SNDLVL_50dB: i64 = 0x32;
                pub const SNDLVL_55dB: i64 = 0x37;
                pub const SNDLVL_60dB: i64 = 0x3C;
                pub const SNDLVL_65dB: i64 = 0x41;
                pub const SNDLVL_70dB: i64 = 0x46;
                pub const SNDLVL_75dB: i64 = 0x4B;
                pub const SNDLVL_80dB: i64 = 0x50;
                pub const SNDLVL_85dB: i64 = 0x55;
                pub const SNDLVL_90dB: i64 = 0x5A;
                pub const SNDLVL_95dB: i64 = 0x5F;
                pub const SNDLVL_IDLE: i64 = 0x3C;
                pub const SNDLVL_NONE: i64 = 0x0;
                pub const SNDLVL_NORM: i64 = 0x4B;
                pub const SNDLVL_100dB: i64 = 0x64;
                pub const SNDLVL_105dB: i64 = 0x69;
                pub const SNDLVL_110dB: i64 = 0x6E;
                pub const SNDLVL_120dB: i64 = 0x78;
                pub const SNDLVL_130dB: i64 = 0x82;
                pub const SNDLVL_140dB: i64 = 0x8C;
                pub const SNDLVL_150dB: i64 = 0x96;
                pub const SNDLVL_180dB: i64 = 0xB4;
                pub const SNDLVL_STATIC: i64 = 0x42;
                pub const SNDLVL_GUNFIRE: i64 = 0x8C;
                pub const SNDLVL_TALKING: i64 = 0x50;
            }
            pub mod PlayBackMode_t {
                pub const Random: i64 = 0x0;
                pub const Sequential: i64 = 0x3;
                pub const RandomWeights: i64 = 0x4;
                pub const RandomAvoidLast: i64 = 0x2;
                pub const RandomNoRepeats: i64 = 0x1;
            }
            pub mod SosGroupType_t {
                pub const SOS_GROUPTYPE_STATIC: i64 = 0x1;
                pub const SOS_GROUPTYPE_DYNAMIC: i64 = 0x0;
            }
            pub mod VMixLFOShape_t {
                pub const LFO_SHAPE_SAW: i64 = 0x3;
                pub const LFO_SHAPE_TRI: i64 = 0x2;
                pub const LFO_SHAPE_SINE: i64 = 0x0;
                pub const LFO_SHAPE_NOISE: i64 = 0x4;
                pub const LFO_SHAPE_SQUARE: i64 = 0x1;
            }
            pub mod CVSoundFormat_t {
                pub const MP3: i64 = 0x2;
                pub const PCM8: i64 = 0x1;
                pub const ADPCM: i64 = 0x3;
                pub const PCM16: i64 = 0x0;
            }
            pub mod EVsndTriggerMode {
                pub const Gate: i64 = 0x1;
                pub const Trigger: i64 = 0x0;
            }
            pub mod SndBeatKeyType_t {
                pub const eSndBeatPatternTypeKeys: i64 = 0x1;
                pub const eSndBeatPatternTypeNone: i64 = 0x0;
                pub const eSndBeatPatternTypeKeyedMidi: i64 = 0x4;
                pub const eSndBeatPatternTypeKeyedFloats: i64 = 0x2;
                pub const eSndBeatPatternTypeKeyedSndEvts: i64 = 0x3;
            }
            pub mod VMixFilterType_t {
                pub const FILTER_NOTCH: i64 = 0x3;
                pub const FILTER_ALLPASS: i64 = 0x7;
                pub const FILTER_LOWPASS: i64 = 0x0;
                pub const FILTER_UNKNOWN: i64 = -0x1;
                pub const FILTER_BANDPASS: i64 = 0x2;
                pub const FILTER_HIGHPASS: i64 = 0x1;
                pub const FILTER_LOW_SHELF: i64 = 0x5;
                pub const FILTER_HIGH_SHELF: i64 = 0x6;
                pub const FILTER_PEAKING_EQ: i64 = 0x4;
                pub const FILTER_PASSTHROUGH: i64 = 0x8;
            }
            pub mod VMixOffsetType_t {
                pub const VO_BOOL: i64 = 0x2;
                pub const VO_CHAR: i64 = 0x0;
                pub const VO_ARRAY: i64 = 0x1;
                pub const VO_FLOAT: i64 = 0x3;
                pub const VO_INT32: i64 = 0x5;
                pub const VO_UINT32: i64 = 0x4;
                pub const VO_VECTOR: i64 = 0x6;
                pub const VO_QUATERNION: i64 = 0x7;
                pub const VO_TYPE_COUNT: i64 = 0xC;
                pub const VO_VSND_INPUT: i64 = 0x9;
                pub const VO_CUBIC_SPLINE: i64 = 0x8;
                pub const VO_SHAREDPTR_IR: i64 = 0xB;
                pub const VO_FLOAT_UTLVECTOR: i64 = 0xA;
            }
            pub mod VMixPannerType_t {
                pub const PANNER_TYPE_LINEAR: i64 = 0x0;
                pub const PANNER_TYPE_EQUAL_POWER: i64 = 0x1;
            }
            pub mod EVsndPlaybackMode {
                pub const Gate: i64 = 0x1;
                pub const Trigger: i64 = 0x0;
            }
            pub mod SndBeatSyncType_t {
                pub const eSndBeatSyncTypeReset: i64 = 0x1;
                pub const eSndBeatSyncTypeInvalid: i64 = 0x0;
                pub const eSndBeatSyncTypeSeekImmediate: i64 = 0x2;
            }
            pub mod SosEditItemType_t {
                pub const SOS_EDIT_ITEM_TYPE_FIELD: i64 = 0x5;
                pub const SOS_EDIT_ITEM_TYPE_STACK: i64 = 0x3;
                pub const SOS_EDIT_ITEM_TYPE_OPERATOR: i64 = 0x4;
                pub const SOS_EDIT_ITEM_TYPE_SOUNDEVENT: i64 = 0x1;
                pub const SOS_EDIT_ITEM_TYPE_SOUNDEVENTS: i64 = 0x0;
                pub const SOS_EDIT_ITEM_TYPE_LIBRARYSTACKS: i64 = 0x2;
            }
            pub mod VMixFilterSlope_t {
                pub const FILTER_SLOPE_MAX: i64 = 0x7;
                pub const FILTER_SLOPE_12dB: i64 = 0x4;
                pub const FILTER_SLOPE_24dB: i64 = 0x5;
                pub const FILTER_SLOPE_36dB: i64 = 0x6;
                pub const FILTER_SLOPE_48dB: i64 = 0x7;
                pub const FILTER_SLOPE_1POLE_6dB: i64 = 0x0;
                pub const FILTER_SLOPE_1POLE_12dB: i64 = 0x1;
                pub const FILTER_SLOPE_1POLE_18dB: i64 = 0x2;
                pub const FILTER_SLOPE_1POLE_24dB: i64 = 0x3;
            }
            pub mod VMixMixDownRule_t {
                pub const MID: i64 = 0x3;
                pub const SUM: i64 = 0x0;
                pub const LEFT: i64 = 0x1;
                pub const SIDE: i64 = 0x4;
                pub const RIGHT: i64 = 0x2;
            }
            pub mod SndBeatEventType_t {
                pub const eSndBeatEventTypeBar: i64 = 0x2;
                pub const eSndBeatEventTypeBeat: i64 = 0x1;
                pub const eSndBeatEventTypeKeys: i64 = 0x5;
                pub const eSndBeatEventTypeLength: i64 = 0x4;
                pub const eSndBeatEventTypePhrase: i64 = 0x3;
                pub const eSndBeatEventTypeInvalid: i64 = 0x0;
            }
            pub mod VMixSendOperator_t {
                pub const TRACK: i64 = 0x8;
                pub const NO_VOICES: i64 = -0x1;
                pub const ALL_VOICES: i64 = 0x0;
                pub const NAMED_SEND: i64 = 0x4;
                pub const ROOM_VOICES: i64 = 0x1;
                pub const ALL_MAX_SEND: i64 = 0x7;
                pub const FACING_VOICES: i64 = 0x2;
                pub const MIXGROUP_VOICES: i64 = 0x3;
                pub const INVERSE_TOTAL_SEND: i64 = 0x6;
                pub const INVERSE_NAMED_SENDS: i64 = 0x5;
            }
            pub mod SosActionStopType_t {
                pub const SOS_STOPTYPE_NONE: i64 = 0x0;
                pub const SOS_STOPTYPE_TIME: i64 = 0x1;
                pub const SOS_STOPTYPE_OPVAR: i64 = 0x2;
            }
            pub mod VMixGraphCommandID_t {
                pub const CMD_INVALID: i64 = -0x1;
                pub const CMD_CONTROL_MAX: i64 = 0xB;
                pub const CMD_SUBMIX_COPY: i64 = 0x18;
                pub const CMD_CONTROL_COPY: i64 = 0x6;
                pub const CMD_SUBMIX_DEBUG: i64 = 0x14;
                pub const CMD_SUBMIX_METER: i64 = 0x1A;
                pub const CMD_SUBMIX_MIX2x1: i64 = 0x15;
                pub const CMD_SUBMIX_OUTPUT: i64 = 0x16;
                pub const CMD_SUBMIX_PROCESS: i64 = 0x10;
                pub const CMD_SUBMIX_GENERATE: i64 = 0x11;
                pub const CMD_SUBMIX_OUTPUTx2: i64 = 0x17;
                pub const CMD_SUBMIX_ACCUMULATE: i64 = 0x19;
                pub const CMD_CONTROL_REMAP_SINE: i64 = 0x9;
                pub const CMD_CONTROL_SINE_BLEND: i64 = 0xF;
                pub const CMD_CONTROL_RESET_TIMER: i64 = 0xC;
                pub const CMD_CONTROL_OUTPUT_STORE: i64 = 0x4;
                pub const CMD_CONTROL_REMAP_LINEAR: i64 = 0x8;
                pub const CMD_CONTROL_EVAL_ENVELOPE: i64 = 0xE;
                pub const CMD_IMPULSERESPONSE_DELAY: i64 = 0x21;
                pub const CMD_IMPULSERESPONSE_RESET: i64 = 0x1F;
                pub const CMD_SUBMIX_METER_SPECTRUM: i64 = 0x1B;
                pub const CMD_CONTROL_EVALUATE_CURVE: i64 = 0x5;
                pub const CMD_CONTROL_INCREMENT_TIMER: i64 = 0xD;
                pub const CMD_CONTROL_REMAP_LOGLINEAR: i64 = 0xA;
                pub const CMD_SUBMIX_EXTRACTCONTAINER: i64 = 0x13;
                pub const CMD_SUBMIX_GENERATE_SIDECHAIN: i64 = 0x12;
                pub const CMD_CONTROL_CONVERT_DB_TO_GAIN: i64 = 0x1;
                pub const CMD_IMPULSERESPONSE_INPUT_STORE: i64 = 0x1C;
                pub const CMD_CONTROL_COND_COPY_IF_NEGATIVE: i64 = 0x7;
                pub const CMD_CONTROL_TRANSIENT_INPUT_RESET: i64 = 0x3;
                pub const CMD_CONTROL_TRANSIENT_INPUT_STORE: i64 = 0x2;
                pub const CMD_REMAP_VSND_TO_IMPULSERESPONSE: i64 = 0x1E;
                pub const CMD_BLEND_VSNDS_TO_IMPULSERESPONSE: i64 = 0x20;
                pub const CMD_PROCESSOR_SET_IMPULSERESPONSE_VALUE: i64 = 0x1D;
            }
            pub mod VMixOffsetCategory_t {
                pub const HEAP_OFFSET: i64 = 0x1;
                pub const INPUT_INDEX: i64 = 0x2;
                pub const NULL_POINTER: i64 = 0x0;
                pub const SUBMIX_INDEX: i64 = 0x3;
            }
            pub mod VMixAutoControlType_t {
                pub const VMIX_AUTO_DISTANCE: i64 = 0x3;
                pub const VMIX_AUTO_PLAYTIME: i64 = 0x2;
                pub const VMIX_AUTO_STACK_VAR: i64 = 0x1;
                pub const VMIX_AUTO_POSITION_X: i64 = 0x4;
                pub const VMIX_AUTO_POSITION_Y: i64 = 0x5;
                pub const VMIX_AUTO_POSITION_Z: i64 = 0x6;
                pub const VMIX_AUTO_SEND_LEVEL: i64 = 0x0;
                pub const VMIX_AUTO_POSITION_VECTOR: i64 = 0x7;
                pub const VMIX_AUTO_LISTENER_YAW_COS: i64 = 0x9;
                pub const VMIX_AUTO_LISTENER_YAW_SIN: i64 = 0x8;
                pub const VMIX_AUTO_LISTENER_ROLL_COS: i64 = 0xD;
                pub const VMIX_AUTO_LISTENER_ROLL_SIN: i64 = 0xC;
                pub const VMIX_AUTO_LISTENER_PITCH_COS: i64 = 0xB;
                pub const VMIX_AUTO_LISTENER_PITCH_SIN: i64 = 0xA;
            }
            pub mod SndBeatSyncStartType_t {
                pub const eSndBeatSyncStartTypeQueue: i64 = 0x2;
                pub const eSndBeatSyncStartTypeInvalid: i64 = 0x0;
                pub const eSndBeatSyncStartTypeImmediate: i64 = 0x1;
            }
            pub mod SndSeqInstrumentType_t {
                pub const eSndSeqInstNull: i64 = 0x0;
                pub const eSndSeqInstSndEvt: i64 = 0x1;
                pub const eSndSeqInstMidiSampler: i64 = 0x2;
            }
            pub mod VMixChannelOperation_t {
                pub const VMIX_CHAN_LEFT: i64 = 0x1;
                pub const VMIX_CHAN_MONO: i64 = 0x4;
                pub const VMIX_CHAN_SWAP: i64 = 0x3;
                pub const VMIX_CHAN_RIGHT: i64 = 0x2;
                pub const VMIX_CHAN_STEREO: i64 = 0x0;
                pub const VMIX_CHAN_MID_SIDE: i64 = 0x5;
            }
            pub mod VMixFilterChannelSet_t {
                pub const FILTER_MID_ONLY: i64 = 0x3;
                pub const FILTER_LEFT_ONLY: i64 = 0x1;
                pub const FILTER_SIDE_ONLY: i64 = 0x4;
                pub const FILTER_RIGHT_ONLY: i64 = 0x2;
                pub const FILTER_ALL_CHANNELS: i64 = 0x0;
                pub const FILTER_CHANNEL_SET_MAX: i64 = 0x5;
            }
            pub mod SndBeatMidiStatusType_t {
                pub const SndSeqMidiStatusNoteOn: i64 = 0x9;
                pub const SndSeqMidiStatusNoteOff: i64 = 0x8;
                pub const SndSeqMidiStatusPitchBend: i64 = 0xE;
                pub const SndSeqMidiStatusCtrlChange: i64 = 0xB;
                pub const SndSeqMidiStatusKeyPressure: i64 = 0xA;
                pub const SndSeqMidiStatusProgramChange: i64 = 0xC;
                pub const SndSeqMidiStatusChannelPressure: i64 = 0xD;
            }
            pub mod SosGroupFieldBehavior_t {
                pub const kMatch: i64 = 0x2;
                pub const kBranch: i64 = 0x1;
                pub const kIgnore: i64 = 0x0;
            }
            pub mod SosActionLimitSortType_t {
                pub const SOS_LIMIT_SORTTYPE_LOWEST: i64 = 0x1;
                pub const SOS_LIMIT_SORTTYPE_HIGHEST: i64 = 0x0;
            }
            pub mod SndBeatTrackPlaybackType_t {
                pub const eSndBeatTrackPlaybackTypeFwd: i64 = 0x1;
                pub const eSndBeatTrackPlaybackTypeStep: i64 = 0x0;
            }
            pub mod SosActionSetParamSortType_t {
                pub const SOS_SETPARAM_SORTTYPE_LOWEST: i64 = 0x1;
                pub const SOS_SETPARAM_SORTTYPE_HIGHEST: i64 = 0x0;
            }
            pub mod VMixSubgraphSwitchInterpolationType_t {
                pub const SUBGRAPH_INTERPOLATION_TEMPORAL_FADE_OUT: i64 = 0x1;
                pub const SUBGRAPH_INTERPOLATION_TEMPORAL_CROSSFADE: i64 = 0x0;
                pub const SUBGRAPH_INTERPOLATION_KEEP_LAST_SUBGRAPH_RUNNING: i64 = 0x2;
            }
        }
    }
}
