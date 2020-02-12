// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace CognitiveSearch.Models
{
    /// <summary> Defines the names of all text analyzers supported by Azure Cognitive Search. </summary>
    public readonly partial struct AnalyzerName : IEquatable<AnalyzerName>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AnalyzerName"/> values are the same. </summary>
        public AnalyzerName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ArMicrosoftValue = "ar.microsoft";
        private const string ArLuceneValue = "ar.lucene";
        private const string HyLuceneValue = "hy.lucene";
        private const string BnMicrosoftValue = "bn.microsoft";
        private const string EuLuceneValue = "eu.lucene";
        private const string BgMicrosoftValue = "bg.microsoft";
        private const string BgLuceneValue = "bg.lucene";
        private const string CaMicrosoftValue = "ca.microsoft";
        private const string CaLuceneValue = "ca.lucene";
        private const string ZhHansMicrosoftValue = "zh-Hans.microsoft";
        private const string ZhHansLuceneValue = "zh-Hans.lucene";
        private const string ZhHantMicrosoftValue = "zh-Hant.microsoft";
        private const string ZhHantLuceneValue = "zh-Hant.lucene";
        private const string HrMicrosoftValue = "hr.microsoft";
        private const string CsMicrosoftValue = "cs.microsoft";
        private const string CsLuceneValue = "cs.lucene";
        private const string DaMicrosoftValue = "da.microsoft";
        private const string DaLuceneValue = "da.lucene";
        private const string NlMicrosoftValue = "nl.microsoft";
        private const string NlLuceneValue = "nl.lucene";
        private const string EnMicrosoftValue = "en.microsoft";
        private const string EnLuceneValue = "en.lucene";
        private const string EtMicrosoftValue = "et.microsoft";
        private const string FiMicrosoftValue = "fi.microsoft";
        private const string FiLuceneValue = "fi.lucene";
        private const string FrMicrosoftValue = "fr.microsoft";
        private const string FrLuceneValue = "fr.lucene";
        private const string GlLuceneValue = "gl.lucene";
        private const string DeMicrosoftValue = "de.microsoft";
        private const string DeLuceneValue = "de.lucene";
        private const string ElMicrosoftValue = "el.microsoft";
        private const string ElLuceneValue = "el.lucene";
        private const string GuMicrosoftValue = "gu.microsoft";
        private const string HeMicrosoftValue = "he.microsoft";
        private const string HiMicrosoftValue = "hi.microsoft";
        private const string HiLuceneValue = "hi.lucene";
        private const string HuMicrosoftValue = "hu.microsoft";
        private const string HuLuceneValue = "hu.lucene";
        private const string IsMicrosoftValue = "is.microsoft";
        private const string IdMicrosoftValue = "id.microsoft";
        private const string IdLuceneValue = "id.lucene";
        private const string GaLuceneValue = "ga.lucene";
        private const string ItMicrosoftValue = "it.microsoft";
        private const string ItLuceneValue = "it.lucene";
        private const string JaMicrosoftValue = "ja.microsoft";
        private const string JaLuceneValue = "ja.lucene";
        private const string KnMicrosoftValue = "kn.microsoft";
        private const string KoMicrosoftValue = "ko.microsoft";
        private const string KoLuceneValue = "ko.lucene";
        private const string LvMicrosoftValue = "lv.microsoft";
        private const string LvLuceneValue = "lv.lucene";
        private const string LtMicrosoftValue = "lt.microsoft";
        private const string MlMicrosoftValue = "ml.microsoft";
        private const string MSMicrosoftValue = "ms.microsoft";
        private const string MrMicrosoftValue = "mr.microsoft";
        private const string NbMicrosoftValue = "nb.microsoft";
        private const string NoLuceneValue = "no.lucene";
        private const string FaLuceneValue = "fa.lucene";
        private const string PlMicrosoftValue = "pl.microsoft";
        private const string PlLuceneValue = "pl.lucene";
        private const string PtBrMicrosoftValue = "pt-BR.microsoft";
        private const string PtBrLuceneValue = "pt-BR.lucene";
        private const string PtMicrosoftValue = "pt-PT.microsoft";
        private const string PtLuceneValue = "pt-PT.lucene";
        private const string PaMicrosoftValue = "pa.microsoft";
        private const string RoMicrosoftValue = "ro.microsoft";
        private const string RoLuceneValue = "ro.lucene";
        private const string RuMicrosoftValue = "ru.microsoft";
        private const string RuLuceneValue = "ru.lucene";
        private const string SrCyrillicMicrosoftValue = "sr-cyrillic.microsoft";
        private const string SrLatinMicrosoftValue = "sr-latin.microsoft";
        private const string SkMicrosoftValue = "sk.microsoft";
        private const string SlMicrosoftValue = "sl.microsoft";
        private const string EsMicrosoftValue = "es.microsoft";
        private const string EsLuceneValue = "es.lucene";
        private const string SvMicrosoftValue = "sv.microsoft";
        private const string SvLuceneValue = "sv.lucene";
        private const string TaMicrosoftValue = "ta.microsoft";
        private const string TeMicrosoftValue = "te.microsoft";
        private const string ThMicrosoftValue = "th.microsoft";
        private const string ThLuceneValue = "th.lucene";
        private const string TrMicrosoftValue = "tr.microsoft";
        private const string TrLuceneValue = "tr.lucene";
        private const string UkMicrosoftValue = "uk.microsoft";
        private const string UrMicrosoftValue = "ur.microsoft";
        private const string ViMicrosoftValue = "vi.microsoft";
        private const string StandardLuceneValue = "standard.lucene";
        private const string StandardasciifoldingLuceneValue = "standardasciifolding.lucene";
        private const string KeywordValue = "keyword";
        private const string PatternValue = "pattern";
        private const string SimpleValue = "simple";
        private const string StopValue = "stop";
        private const string WhitespaceValue = "whitespace";

        /// <summary> ar.microsoft. </summary>
        public static AnalyzerName ArMicrosoft { get; } = new AnalyzerName(ArMicrosoftValue);
        /// <summary> ar.lucene. </summary>
        public static AnalyzerName ArLucene { get; } = new AnalyzerName(ArLuceneValue);
        /// <summary> hy.lucene. </summary>
        public static AnalyzerName HyLucene { get; } = new AnalyzerName(HyLuceneValue);
        /// <summary> bn.microsoft. </summary>
        public static AnalyzerName BnMicrosoft { get; } = new AnalyzerName(BnMicrosoftValue);
        /// <summary> eu.lucene. </summary>
        public static AnalyzerName EuLucene { get; } = new AnalyzerName(EuLuceneValue);
        /// <summary> bg.microsoft. </summary>
        public static AnalyzerName BgMicrosoft { get; } = new AnalyzerName(BgMicrosoftValue);
        /// <summary> bg.lucene. </summary>
        public static AnalyzerName BgLucene { get; } = new AnalyzerName(BgLuceneValue);
        /// <summary> ca.microsoft. </summary>
        public static AnalyzerName CaMicrosoft { get; } = new AnalyzerName(CaMicrosoftValue);
        /// <summary> ca.lucene. </summary>
        public static AnalyzerName CaLucene { get; } = new AnalyzerName(CaLuceneValue);
        /// <summary> zh-Hans.microsoft. </summary>
        public static AnalyzerName ZhHansMicrosoft { get; } = new AnalyzerName(ZhHansMicrosoftValue);
        /// <summary> zh-Hans.lucene. </summary>
        public static AnalyzerName ZhHansLucene { get; } = new AnalyzerName(ZhHansLuceneValue);
        /// <summary> zh-Hant.microsoft. </summary>
        public static AnalyzerName ZhHantMicrosoft { get; } = new AnalyzerName(ZhHantMicrosoftValue);
        /// <summary> zh-Hant.lucene. </summary>
        public static AnalyzerName ZhHantLucene { get; } = new AnalyzerName(ZhHantLuceneValue);
        /// <summary> hr.microsoft. </summary>
        public static AnalyzerName HrMicrosoft { get; } = new AnalyzerName(HrMicrosoftValue);
        /// <summary> cs.microsoft. </summary>
        public static AnalyzerName CsMicrosoft { get; } = new AnalyzerName(CsMicrosoftValue);
        /// <summary> cs.lucene. </summary>
        public static AnalyzerName CsLucene { get; } = new AnalyzerName(CsLuceneValue);
        /// <summary> da.microsoft. </summary>
        public static AnalyzerName DaMicrosoft { get; } = new AnalyzerName(DaMicrosoftValue);
        /// <summary> da.lucene. </summary>
        public static AnalyzerName DaLucene { get; } = new AnalyzerName(DaLuceneValue);
        /// <summary> nl.microsoft. </summary>
        public static AnalyzerName NlMicrosoft { get; } = new AnalyzerName(NlMicrosoftValue);
        /// <summary> nl.lucene. </summary>
        public static AnalyzerName NlLucene { get; } = new AnalyzerName(NlLuceneValue);
        /// <summary> en.microsoft. </summary>
        public static AnalyzerName EnMicrosoft { get; } = new AnalyzerName(EnMicrosoftValue);
        /// <summary> en.lucene. </summary>
        public static AnalyzerName EnLucene { get; } = new AnalyzerName(EnLuceneValue);
        /// <summary> et.microsoft. </summary>
        public static AnalyzerName EtMicrosoft { get; } = new AnalyzerName(EtMicrosoftValue);
        /// <summary> fi.microsoft. </summary>
        public static AnalyzerName FiMicrosoft { get; } = new AnalyzerName(FiMicrosoftValue);
        /// <summary> fi.lucene. </summary>
        public static AnalyzerName FiLucene { get; } = new AnalyzerName(FiLuceneValue);
        /// <summary> fr.microsoft. </summary>
        public static AnalyzerName FrMicrosoft { get; } = new AnalyzerName(FrMicrosoftValue);
        /// <summary> fr.lucene. </summary>
        public static AnalyzerName FrLucene { get; } = new AnalyzerName(FrLuceneValue);
        /// <summary> gl.lucene. </summary>
        public static AnalyzerName GlLucene { get; } = new AnalyzerName(GlLuceneValue);
        /// <summary> de.microsoft. </summary>
        public static AnalyzerName DeMicrosoft { get; } = new AnalyzerName(DeMicrosoftValue);
        /// <summary> de.lucene. </summary>
        public static AnalyzerName DeLucene { get; } = new AnalyzerName(DeLuceneValue);
        /// <summary> el.microsoft. </summary>
        public static AnalyzerName ElMicrosoft { get; } = new AnalyzerName(ElMicrosoftValue);
        /// <summary> el.lucene. </summary>
        public static AnalyzerName ElLucene { get; } = new AnalyzerName(ElLuceneValue);
        /// <summary> gu.microsoft. </summary>
        public static AnalyzerName GuMicrosoft { get; } = new AnalyzerName(GuMicrosoftValue);
        /// <summary> he.microsoft. </summary>
        public static AnalyzerName HeMicrosoft { get; } = new AnalyzerName(HeMicrosoftValue);
        /// <summary> hi.microsoft. </summary>
        public static AnalyzerName HiMicrosoft { get; } = new AnalyzerName(HiMicrosoftValue);
        /// <summary> hi.lucene. </summary>
        public static AnalyzerName HiLucene { get; } = new AnalyzerName(HiLuceneValue);
        /// <summary> hu.microsoft. </summary>
        public static AnalyzerName HuMicrosoft { get; } = new AnalyzerName(HuMicrosoftValue);
        /// <summary> hu.lucene. </summary>
        public static AnalyzerName HuLucene { get; } = new AnalyzerName(HuLuceneValue);
        /// <summary> is.microsoft. </summary>
        public static AnalyzerName IsMicrosoft { get; } = new AnalyzerName(IsMicrosoftValue);
        /// <summary> id.microsoft. </summary>
        public static AnalyzerName IdMicrosoft { get; } = new AnalyzerName(IdMicrosoftValue);
        /// <summary> id.lucene. </summary>
        public static AnalyzerName IdLucene { get; } = new AnalyzerName(IdLuceneValue);
        /// <summary> ga.lucene. </summary>
        public static AnalyzerName GaLucene { get; } = new AnalyzerName(GaLuceneValue);
        /// <summary> it.microsoft. </summary>
        public static AnalyzerName ItMicrosoft { get; } = new AnalyzerName(ItMicrosoftValue);
        /// <summary> it.lucene. </summary>
        public static AnalyzerName ItLucene { get; } = new AnalyzerName(ItLuceneValue);
        /// <summary> ja.microsoft. </summary>
        public static AnalyzerName JaMicrosoft { get; } = new AnalyzerName(JaMicrosoftValue);
        /// <summary> ja.lucene. </summary>
        public static AnalyzerName JaLucene { get; } = new AnalyzerName(JaLuceneValue);
        /// <summary> kn.microsoft. </summary>
        public static AnalyzerName KnMicrosoft { get; } = new AnalyzerName(KnMicrosoftValue);
        /// <summary> ko.microsoft. </summary>
        public static AnalyzerName KoMicrosoft { get; } = new AnalyzerName(KoMicrosoftValue);
        /// <summary> ko.lucene. </summary>
        public static AnalyzerName KoLucene { get; } = new AnalyzerName(KoLuceneValue);
        /// <summary> lv.microsoft. </summary>
        public static AnalyzerName LvMicrosoft { get; } = new AnalyzerName(LvMicrosoftValue);
        /// <summary> lv.lucene. </summary>
        public static AnalyzerName LvLucene { get; } = new AnalyzerName(LvLuceneValue);
        /// <summary> lt.microsoft. </summary>
        public static AnalyzerName LtMicrosoft { get; } = new AnalyzerName(LtMicrosoftValue);
        /// <summary> ml.microsoft. </summary>
        public static AnalyzerName MlMicrosoft { get; } = new AnalyzerName(MlMicrosoftValue);
        /// <summary> ms.microsoft. </summary>
        public static AnalyzerName MSMicrosoft { get; } = new AnalyzerName(MSMicrosoftValue);
        /// <summary> mr.microsoft. </summary>
        public static AnalyzerName MrMicrosoft { get; } = new AnalyzerName(MrMicrosoftValue);
        /// <summary> nb.microsoft. </summary>
        public static AnalyzerName NbMicrosoft { get; } = new AnalyzerName(NbMicrosoftValue);
        /// <summary> no.lucene. </summary>
        public static AnalyzerName NoLucene { get; } = new AnalyzerName(NoLuceneValue);
        /// <summary> fa.lucene. </summary>
        public static AnalyzerName FaLucene { get; } = new AnalyzerName(FaLuceneValue);
        /// <summary> pl.microsoft. </summary>
        public static AnalyzerName PlMicrosoft { get; } = new AnalyzerName(PlMicrosoftValue);
        /// <summary> pl.lucene. </summary>
        public static AnalyzerName PlLucene { get; } = new AnalyzerName(PlLuceneValue);
        /// <summary> pt-BR.microsoft. </summary>
        public static AnalyzerName PtBrMicrosoft { get; } = new AnalyzerName(PtBrMicrosoftValue);
        /// <summary> pt-BR.lucene. </summary>
        public static AnalyzerName PtBrLucene { get; } = new AnalyzerName(PtBrLuceneValue);
        /// <summary> pt-PT.microsoft. </summary>
        public static AnalyzerName PtMicrosoft { get; } = new AnalyzerName(PtMicrosoftValue);
        /// <summary> pt-PT.lucene. </summary>
        public static AnalyzerName PtLucene { get; } = new AnalyzerName(PtLuceneValue);
        /// <summary> pa.microsoft. </summary>
        public static AnalyzerName PaMicrosoft { get; } = new AnalyzerName(PaMicrosoftValue);
        /// <summary> ro.microsoft. </summary>
        public static AnalyzerName RoMicrosoft { get; } = new AnalyzerName(RoMicrosoftValue);
        /// <summary> ro.lucene. </summary>
        public static AnalyzerName RoLucene { get; } = new AnalyzerName(RoLuceneValue);
        /// <summary> ru.microsoft. </summary>
        public static AnalyzerName RuMicrosoft { get; } = new AnalyzerName(RuMicrosoftValue);
        /// <summary> ru.lucene. </summary>
        public static AnalyzerName RuLucene { get; } = new AnalyzerName(RuLuceneValue);
        /// <summary> sr-cyrillic.microsoft. </summary>
        public static AnalyzerName SrCyrillicMicrosoft { get; } = new AnalyzerName(SrCyrillicMicrosoftValue);
        /// <summary> sr-latin.microsoft. </summary>
        public static AnalyzerName SrLatinMicrosoft { get; } = new AnalyzerName(SrLatinMicrosoftValue);
        /// <summary> sk.microsoft. </summary>
        public static AnalyzerName SkMicrosoft { get; } = new AnalyzerName(SkMicrosoftValue);
        /// <summary> sl.microsoft. </summary>
        public static AnalyzerName SlMicrosoft { get; } = new AnalyzerName(SlMicrosoftValue);
        /// <summary> es.microsoft. </summary>
        public static AnalyzerName EsMicrosoft { get; } = new AnalyzerName(EsMicrosoftValue);
        /// <summary> es.lucene. </summary>
        public static AnalyzerName EsLucene { get; } = new AnalyzerName(EsLuceneValue);
        /// <summary> sv.microsoft. </summary>
        public static AnalyzerName SvMicrosoft { get; } = new AnalyzerName(SvMicrosoftValue);
        /// <summary> sv.lucene. </summary>
        public static AnalyzerName SvLucene { get; } = new AnalyzerName(SvLuceneValue);
        /// <summary> ta.microsoft. </summary>
        public static AnalyzerName TaMicrosoft { get; } = new AnalyzerName(TaMicrosoftValue);
        /// <summary> te.microsoft. </summary>
        public static AnalyzerName TeMicrosoft { get; } = new AnalyzerName(TeMicrosoftValue);
        /// <summary> th.microsoft. </summary>
        public static AnalyzerName ThMicrosoft { get; } = new AnalyzerName(ThMicrosoftValue);
        /// <summary> th.lucene. </summary>
        public static AnalyzerName ThLucene { get; } = new AnalyzerName(ThLuceneValue);
        /// <summary> tr.microsoft. </summary>
        public static AnalyzerName TrMicrosoft { get; } = new AnalyzerName(TrMicrosoftValue);
        /// <summary> tr.lucene. </summary>
        public static AnalyzerName TrLucene { get; } = new AnalyzerName(TrLuceneValue);
        /// <summary> uk.microsoft. </summary>
        public static AnalyzerName UkMicrosoft { get; } = new AnalyzerName(UkMicrosoftValue);
        /// <summary> ur.microsoft. </summary>
        public static AnalyzerName UrMicrosoft { get; } = new AnalyzerName(UrMicrosoftValue);
        /// <summary> vi.microsoft. </summary>
        public static AnalyzerName ViMicrosoft { get; } = new AnalyzerName(ViMicrosoftValue);
        /// <summary> standard.lucene. </summary>
        public static AnalyzerName StandardLucene { get; } = new AnalyzerName(StandardLuceneValue);
        /// <summary> standardasciifolding.lucene. </summary>
        public static AnalyzerName StandardasciifoldingLucene { get; } = new AnalyzerName(StandardasciifoldingLuceneValue);
        /// <summary> keyword. </summary>
        public static AnalyzerName Keyword { get; } = new AnalyzerName(KeywordValue);
        /// <summary> pattern. </summary>
        public static AnalyzerName Pattern { get; } = new AnalyzerName(PatternValue);
        /// <summary> simple. </summary>
        public static AnalyzerName Simple { get; } = new AnalyzerName(SimpleValue);
        /// <summary> stop. </summary>
        public static AnalyzerName Stop { get; } = new AnalyzerName(StopValue);
        /// <summary> whitespace. </summary>
        public static AnalyzerName Whitespace { get; } = new AnalyzerName(WhitespaceValue);
        /// <summary> Determines if two <see cref="AnalyzerName"/> values are the same. </summary>
        public static bool operator ==(AnalyzerName left, AnalyzerName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnalyzerName"/> values are not the same. </summary>
        public static bool operator !=(AnalyzerName left, AnalyzerName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AnalyzerName"/>. </summary>
        public static implicit operator AnalyzerName(string value) => new AnalyzerName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnalyzerName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnalyzerName other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
