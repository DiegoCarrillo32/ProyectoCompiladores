//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/kosti/RiderProjects/AvaloniaApplication5/AvaloniaApplication5/MiniCScanner.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace gen {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public partial class MiniCScanner : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		Using=1, Class=2, VarDecl=3, ClassDecl=4, MethodDecl=5, Type=6, Void=7, 
		Statement=8, Semicolon=9, Lbrace=10, Rbrace=11, Lparen=12, Rparen=13, 
		LList=14, RList=15, Comma=16, If=17, Else=18, For=19, While=20, Break=21, 
		Return=22, Read=23, Write=24, Add=25, Del=26, Len=27, ActPars=28, Condition=29, 
		CondTerm=30, CondFact=31, Cast=32, Expr=33, Term=34, Factor=35, Designator=36, 
		StringConst=37, CharConst=38, Number=39, Colon=40, Dash=41, Plus=42, Minus=43, 
		Mult=44, Div=45, Mod=46, LogicalAnd=47, LogicalOr=48, QuestionMark=49, 
		PlusEquals=50, PlusPlus=51, MinusMinus=52, DOT=53, Assign=54, MinusEquals=55, 
		MultEquals=56, DivEquals=57, ModEquals=58, Equals=59, NotEquals=60, LogicalNot=61, 
		LessThan=62, GreaterThan=63, LessThanOrEquals=64, GreaterThanOrEquals=65, 
		True=66, False=67, New=68, PLAIN_TEXT=69, NUM=70, ID=71, WS=72, COMMENT=73, 
		MULTIPLE_COMMENT=74;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"Using", "Class", "VarDecl", "ClassDecl", "MethodDecl", "Type", "Void", 
		"Statement", "Semicolon", "Lbrace", "Rbrace", "Lparen", "Rparen", "LList", 
		"RList", "Comma", "If", "Else", "For", "While", "Break", "Return", "Read", 
		"Write", "Add", "Del", "Len", "ActPars", "Condition", "CondTerm", "CondFact", 
		"Cast", "Expr", "Term", "Factor", "Designator", "StringConst", "CharConst", 
		"Number", "Colon", "Dash", "Plus", "Minus", "Mult", "Div", "Mod", "LogicalAnd", 
		"LogicalOr", "QuestionMark", "PlusEquals", "PlusPlus", "MinusMinus", "DOT", 
		"Assign", "MinusEquals", "MultEquals", "DivEquals", "ModEquals", "Equals", 
		"NotEquals", "LogicalNot", "LessThan", "GreaterThan", "LessThanOrEquals", 
		"GreaterThanOrEquals", "True", "False", "New", "PLAIN_TEXT", "NUM", "ID", 
		"LETTER", "DIGIT", "SPECIAL", "WS", "COMMENT", "MULTIPLE_COMMENT"
	};


	public MiniCScanner(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MiniCScanner(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'using'", "'class'", "'varDecl'", "'classDecl'", "'methodDecl'", 
		"'type'", "'Void'", "'statement'", "';'", "'{'", "'}'", "'('", "')'", 
		"'['", "']'", "','", "'if'", "'else'", "'for'", "'while'", "'break'", 
		"'return'", "'read'", "'write'", "'add'", "'del'", "'len'", "'actPars'", 
		"'condition'", "'condTerm'", "'condFact'", "'cast'", "'expr'", "'term'", 
		"'factor'", "'designator'", "'string'", "'char'", "'number'", "':'", null, 
		"'+'", null, "'*'", "'/'", "'%'", "'&&'", "'||'", "'?'", "'+='", "'++'", 
		"'--'", "'.'", "'='", "'-='", "'*='", "'/='", "'%='", "'=='", "'!='", 
		"'!'", "'<'", "'>'", "'<='", "'>='", "'true'", "'false'", "'new'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Using", "Class", "VarDecl", "ClassDecl", "MethodDecl", "Type", 
		"Void", "Statement", "Semicolon", "Lbrace", "Rbrace", "Lparen", "Rparen", 
		"LList", "RList", "Comma", "If", "Else", "For", "While", "Break", "Return", 
		"Read", "Write", "Add", "Del", "Len", "ActPars", "Condition", "CondTerm", 
		"CondFact", "Cast", "Expr", "Term", "Factor", "Designator", "StringConst", 
		"CharConst", "Number", "Colon", "Dash", "Plus", "Minus", "Mult", "Div", 
		"Mod", "LogicalAnd", "LogicalOr", "QuestionMark", "PlusEquals", "PlusPlus", 
		"MinusMinus", "DOT", "Assign", "MinusEquals", "MultEquals", "DivEquals", 
		"ModEquals", "Equals", "NotEquals", "LogicalNot", "LessThan", "GreaterThan", 
		"LessThanOrEquals", "GreaterThanOrEquals", "True", "False", "New", "PLAIN_TEXT", 
		"NUM", "ID", "WS", "COMMENT", "MULTIPLE_COMMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "MiniCScanner.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MiniCScanner() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,74,523,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,2,65,7,65,2,66,7,66,2,67,7,67,2,68,7,68,2,69,7,69,2,70,
		7,70,2,71,7,71,2,72,7,72,2,73,7,73,2,74,7,74,2,75,7,75,2,76,7,76,1,0,1,
		0,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,2,1,2,
		1,2,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,
		4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,
		1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,9,1,9,1,10,1,10,1,11,1,11,1,12,1,
		12,1,13,1,13,1,14,1,14,1,15,1,15,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,
		17,1,18,1,18,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,
		20,1,20,1,20,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,22,1,22,1,
		22,1,23,1,23,1,23,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,25,1,25,1,25,1,
		25,1,26,1,26,1,26,1,26,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,28,1,
		28,1,28,1,28,1,28,1,28,1,28,1,28,1,28,1,28,1,29,1,29,1,29,1,29,1,29,1,
		29,1,29,1,29,1,29,1,30,1,30,1,30,1,30,1,30,1,30,1,30,1,30,1,30,1,31,1,
		31,1,31,1,31,1,31,1,32,1,32,1,32,1,32,1,32,1,33,1,33,1,33,1,33,1,33,1,
		34,1,34,1,34,1,34,1,34,1,34,1,34,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,
		35,1,35,1,35,1,35,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,37,1,37,1,37,1,
		37,1,37,1,38,1,38,1,38,1,38,1,38,1,38,1,38,1,39,1,39,1,40,1,40,1,41,1,
		41,1,42,1,42,1,43,1,43,1,44,1,44,1,45,1,45,1,46,1,46,1,46,1,47,1,47,1,
		47,1,48,1,48,1,49,1,49,1,49,1,50,1,50,1,50,1,51,1,51,1,51,1,52,1,52,1,
		53,1,53,1,54,1,54,1,54,1,55,1,55,1,55,1,56,1,56,1,56,1,57,1,57,1,57,1,
		58,1,58,1,58,1,59,1,59,1,59,1,60,1,60,1,61,1,61,1,62,1,62,1,63,1,63,1,
		63,1,64,1,64,1,64,1,65,1,65,1,65,1,65,1,65,1,66,1,66,1,66,1,66,1,66,1,
		66,1,67,1,67,1,67,1,67,1,68,1,68,5,68,457,8,68,10,68,12,68,460,9,68,1,
		68,1,68,1,69,4,69,465,8,69,11,69,12,69,466,1,69,1,69,4,69,471,8,69,11,
		69,12,69,472,3,69,475,8,69,1,70,1,70,1,70,5,70,480,8,70,10,70,12,70,483,
		9,70,1,71,3,71,486,8,71,1,72,1,72,1,73,1,73,1,74,4,74,493,8,74,11,74,12,
		74,494,1,74,1,74,1,75,1,75,1,75,1,75,5,75,503,8,75,10,75,12,75,506,9,75,
		1,75,1,75,1,76,1,76,1,76,1,76,5,76,514,8,76,10,76,12,76,517,9,76,1,76,
		1,76,1,76,1,76,1,76,2,458,515,0,77,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,
		17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,
		41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,57,29,59,30,61,31,63,32,
		65,33,67,34,69,35,71,36,73,37,75,38,77,39,79,40,81,41,83,42,85,43,87,44,
		89,45,91,46,93,47,95,48,97,49,99,50,101,51,103,52,105,53,107,54,109,55,
		111,56,113,57,115,58,117,59,119,60,121,61,123,62,125,63,127,64,129,65,
		131,66,133,67,135,68,137,69,139,70,141,71,143,0,145,0,147,0,149,72,151,
		73,153,74,1,0,5,2,0,65,90,97,122,1,0,48,57,338,0,33,47,58,64,91,96,123,
		126,161,169,171,172,174,177,180,180,182,184,187,187,191,191,215,215,247,
		247,706,709,722,735,741,747,749,749,751,767,885,885,894,894,900,901,903,
		903,1014,1014,1154,1154,1370,1375,1417,1418,1421,1423,1470,1470,1472,1472,
		1475,1475,1478,1478,1523,1524,1542,1551,1563,1563,1565,1567,1642,1645,
		1748,1748,1758,1758,1769,1769,1789,1790,1792,1805,2038,2041,2046,2047,
		2096,2110,2142,2142,2184,2184,2404,2405,2416,2416,2546,2547,2554,2555,
		2557,2557,2678,2678,2800,2801,2928,2928,3059,3066,3191,3191,3199,3199,
		3204,3204,3407,3407,3449,3449,3572,3572,3647,3647,3663,3663,3674,3675,
		3841,3863,3866,3871,3892,3892,3894,3894,3896,3896,3898,3901,3973,3973,
		4030,4037,4039,4044,4046,4058,4170,4175,4254,4255,4347,4347,4960,4968,
		5008,5017,5120,5120,5741,5742,5787,5788,5867,5869,5941,5942,6100,6102,
		6104,6107,6144,6154,6464,6464,6468,6469,6622,6655,6686,6687,6816,6822,
		6824,6829,7002,7018,7028,7038,7164,7167,7227,7231,7294,7295,7360,7367,
		7379,7379,8125,8125,8127,8129,8141,8143,8157,8159,8173,8175,8189,8190,
		8208,8231,8240,8286,8314,8318,8330,8334,8352,8384,8448,8449,8451,8454,
		8456,8457,8468,8468,8470,8472,8478,8483,8485,8485,8487,8487,8489,8489,
		8494,8494,8506,8507,8512,8516,8522,8525,8527,8527,8586,8587,8592,9254,
		9280,9290,9372,9449,9472,10101,10132,11123,11126,11157,11159,11263,11493,
		11498,11513,11516,11518,11519,11632,11632,11776,11822,11824,11869,11904,
		11929,11931,12019,12032,12245,12272,12283,12289,12292,12296,12320,12336,
		12336,12342,12343,12349,12351,12443,12444,12448,12448,12539,12539,12688,
		12689,12694,12703,12736,12771,12800,12830,12842,12871,12880,12880,12896,
		12927,12938,12976,12992,13311,19904,19967,42128,42182,42238,42239,42509,
		42511,42611,42611,42622,42622,42738,42743,42752,42774,42784,42785,42889,
		42890,43048,43051,43062,43065,43124,43127,43214,43215,43256,43258,43260,
		43260,43310,43311,43359,43359,43457,43469,43486,43487,43612,43615,43639,
		43641,43742,43743,43760,43761,43867,43867,43882,43883,44011,44011,64297,
		64297,64434,64450,64830,64847,64975,64975,65020,65023,65040,65049,65072,
		65106,65108,65126,65128,65131,65281,65295,65306,65312,65339,65344,65371,
		65381,65504,65510,65512,65518,65532,65533,65792,65794,65847,65855,65913,
		65929,65932,65934,65936,65948,65952,65952,66000,66044,66463,66463,66512,
		66512,66927,66927,67671,67671,67703,67704,67871,67871,67903,67903,68176,
		68184,68223,68223,68296,68296,68336,68342,68409,68415,68505,68508,69293,
		69293,69461,69465,69510,69513,69703,69709,69819,69820,69822,69825,69952,
		69955,70004,70005,70085,70088,70093,70093,70107,70107,70109,70111,70200,
		70205,70313,70313,70731,70735,70746,70747,70749,70749,70854,70854,71105,
		71127,71233,71235,71264,71276,71353,71353,71484,71487,71739,71739,72004,
		72006,72162,72162,72255,72262,72346,72348,72350,72354,72769,72773,72816,
		72817,73463,73464,73685,73713,73727,73727,74864,74868,77809,77810,92782,
		92783,92917,92917,92983,92991,92996,92997,93847,93850,94178,94178,113820,
		113820,113823,113823,118608,118723,118784,119029,119040,119078,119081,
		119140,119146,119148,119171,119172,119180,119209,119214,119274,119296,
		119361,119365,119365,119552,119638,120513,120513,120539,120539,120571,
		120571,120597,120597,120629,120629,120655,120655,120687,120687,120713,
		120713,120745,120745,120771,120771,120832,121343,121399,121402,121453,
		121460,121462,121475,121477,121483,123215,123215,123647,123647,125278,
		125279,126124,126124,126128,126128,126254,126254,126704,126705,126976,
		127019,127024,127123,127136,127150,127153,127167,127169,127183,127185,
		127221,127245,127405,127462,127490,127504,127547,127552,127560,127568,
		127569,127584,127589,127744,128727,128733,128748,128752,128764,128768,
		128883,128896,128984,128992,129003,129008,129008,129024,129035,129040,
		129095,129104,129113,129120,129159,129168,129197,129200,129201,129280,
		129619,129632,129645,129648,129652,129656,129660,129664,129670,129680,
		129708,129712,129722,129728,129733,129744,129753,129760,129767,129776,
		129782,129792,129938,129940,129994,3,0,9,10,13,13,32,32,2,0,10,10,13,13,
		528,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,
		0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,
		0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,
		1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,
		0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,
		1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,
		0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,
		1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,
		0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,
		1,0,0,0,0,101,1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,0,107,1,0,0,0,0,109,
		1,0,0,0,0,111,1,0,0,0,0,113,1,0,0,0,0,115,1,0,0,0,0,117,1,0,0,0,0,119,
		1,0,0,0,0,121,1,0,0,0,0,123,1,0,0,0,0,125,1,0,0,0,0,127,1,0,0,0,0,129,
		1,0,0,0,0,131,1,0,0,0,0,133,1,0,0,0,0,135,1,0,0,0,0,137,1,0,0,0,0,139,
		1,0,0,0,0,141,1,0,0,0,0,149,1,0,0,0,0,151,1,0,0,0,0,153,1,0,0,0,1,155,
		1,0,0,0,3,161,1,0,0,0,5,167,1,0,0,0,7,175,1,0,0,0,9,185,1,0,0,0,11,196,
		1,0,0,0,13,201,1,0,0,0,15,206,1,0,0,0,17,216,1,0,0,0,19,218,1,0,0,0,21,
		220,1,0,0,0,23,222,1,0,0,0,25,224,1,0,0,0,27,226,1,0,0,0,29,228,1,0,0,
		0,31,230,1,0,0,0,33,232,1,0,0,0,35,235,1,0,0,0,37,240,1,0,0,0,39,244,1,
		0,0,0,41,250,1,0,0,0,43,256,1,0,0,0,45,263,1,0,0,0,47,268,1,0,0,0,49,274,
		1,0,0,0,51,278,1,0,0,0,53,282,1,0,0,0,55,286,1,0,0,0,57,294,1,0,0,0,59,
		304,1,0,0,0,61,313,1,0,0,0,63,322,1,0,0,0,65,327,1,0,0,0,67,332,1,0,0,
		0,69,337,1,0,0,0,71,344,1,0,0,0,73,355,1,0,0,0,75,362,1,0,0,0,77,367,1,
		0,0,0,79,374,1,0,0,0,81,376,1,0,0,0,83,378,1,0,0,0,85,380,1,0,0,0,87,382,
		1,0,0,0,89,384,1,0,0,0,91,386,1,0,0,0,93,388,1,0,0,0,95,391,1,0,0,0,97,
		394,1,0,0,0,99,396,1,0,0,0,101,399,1,0,0,0,103,402,1,0,0,0,105,405,1,0,
		0,0,107,407,1,0,0,0,109,409,1,0,0,0,111,412,1,0,0,0,113,415,1,0,0,0,115,
		418,1,0,0,0,117,421,1,0,0,0,119,424,1,0,0,0,121,427,1,0,0,0,123,429,1,
		0,0,0,125,431,1,0,0,0,127,433,1,0,0,0,129,436,1,0,0,0,131,439,1,0,0,0,
		133,444,1,0,0,0,135,450,1,0,0,0,137,454,1,0,0,0,139,464,1,0,0,0,141,476,
		1,0,0,0,143,485,1,0,0,0,145,487,1,0,0,0,147,489,1,0,0,0,149,492,1,0,0,
		0,151,498,1,0,0,0,153,509,1,0,0,0,155,156,5,117,0,0,156,157,5,115,0,0,
		157,158,5,105,0,0,158,159,5,110,0,0,159,160,5,103,0,0,160,2,1,0,0,0,161,
		162,5,99,0,0,162,163,5,108,0,0,163,164,5,97,0,0,164,165,5,115,0,0,165,
		166,5,115,0,0,166,4,1,0,0,0,167,168,5,118,0,0,168,169,5,97,0,0,169,170,
		5,114,0,0,170,171,5,68,0,0,171,172,5,101,0,0,172,173,5,99,0,0,173,174,
		5,108,0,0,174,6,1,0,0,0,175,176,5,99,0,0,176,177,5,108,0,0,177,178,5,97,
		0,0,178,179,5,115,0,0,179,180,5,115,0,0,180,181,5,68,0,0,181,182,5,101,
		0,0,182,183,5,99,0,0,183,184,5,108,0,0,184,8,1,0,0,0,185,186,5,109,0,0,
		186,187,5,101,0,0,187,188,5,116,0,0,188,189,5,104,0,0,189,190,5,111,0,
		0,190,191,5,100,0,0,191,192,5,68,0,0,192,193,5,101,0,0,193,194,5,99,0,
		0,194,195,5,108,0,0,195,10,1,0,0,0,196,197,5,116,0,0,197,198,5,121,0,0,
		198,199,5,112,0,0,199,200,5,101,0,0,200,12,1,0,0,0,201,202,5,86,0,0,202,
		203,5,111,0,0,203,204,5,105,0,0,204,205,5,100,0,0,205,14,1,0,0,0,206,207,
		5,115,0,0,207,208,5,116,0,0,208,209,5,97,0,0,209,210,5,116,0,0,210,211,
		5,101,0,0,211,212,5,109,0,0,212,213,5,101,0,0,213,214,5,110,0,0,214,215,
		5,116,0,0,215,16,1,0,0,0,216,217,5,59,0,0,217,18,1,0,0,0,218,219,5,123,
		0,0,219,20,1,0,0,0,220,221,5,125,0,0,221,22,1,0,0,0,222,223,5,40,0,0,223,
		24,1,0,0,0,224,225,5,41,0,0,225,26,1,0,0,0,226,227,5,91,0,0,227,28,1,0,
		0,0,228,229,5,93,0,0,229,30,1,0,0,0,230,231,5,44,0,0,231,32,1,0,0,0,232,
		233,5,105,0,0,233,234,5,102,0,0,234,34,1,0,0,0,235,236,5,101,0,0,236,237,
		5,108,0,0,237,238,5,115,0,0,238,239,5,101,0,0,239,36,1,0,0,0,240,241,5,
		102,0,0,241,242,5,111,0,0,242,243,5,114,0,0,243,38,1,0,0,0,244,245,5,119,
		0,0,245,246,5,104,0,0,246,247,5,105,0,0,247,248,5,108,0,0,248,249,5,101,
		0,0,249,40,1,0,0,0,250,251,5,98,0,0,251,252,5,114,0,0,252,253,5,101,0,
		0,253,254,5,97,0,0,254,255,5,107,0,0,255,42,1,0,0,0,256,257,5,114,0,0,
		257,258,5,101,0,0,258,259,5,116,0,0,259,260,5,117,0,0,260,261,5,114,0,
		0,261,262,5,110,0,0,262,44,1,0,0,0,263,264,5,114,0,0,264,265,5,101,0,0,
		265,266,5,97,0,0,266,267,5,100,0,0,267,46,1,0,0,0,268,269,5,119,0,0,269,
		270,5,114,0,0,270,271,5,105,0,0,271,272,5,116,0,0,272,273,5,101,0,0,273,
		48,1,0,0,0,274,275,5,97,0,0,275,276,5,100,0,0,276,277,5,100,0,0,277,50,
		1,0,0,0,278,279,5,100,0,0,279,280,5,101,0,0,280,281,5,108,0,0,281,52,1,
		0,0,0,282,283,5,108,0,0,283,284,5,101,0,0,284,285,5,110,0,0,285,54,1,0,
		0,0,286,287,5,97,0,0,287,288,5,99,0,0,288,289,5,116,0,0,289,290,5,80,0,
		0,290,291,5,97,0,0,291,292,5,114,0,0,292,293,5,115,0,0,293,56,1,0,0,0,
		294,295,5,99,0,0,295,296,5,111,0,0,296,297,5,110,0,0,297,298,5,100,0,0,
		298,299,5,105,0,0,299,300,5,116,0,0,300,301,5,105,0,0,301,302,5,111,0,
		0,302,303,5,110,0,0,303,58,1,0,0,0,304,305,5,99,0,0,305,306,5,111,0,0,
		306,307,5,110,0,0,307,308,5,100,0,0,308,309,5,84,0,0,309,310,5,101,0,0,
		310,311,5,114,0,0,311,312,5,109,0,0,312,60,1,0,0,0,313,314,5,99,0,0,314,
		315,5,111,0,0,315,316,5,110,0,0,316,317,5,100,0,0,317,318,5,70,0,0,318,
		319,5,97,0,0,319,320,5,99,0,0,320,321,5,116,0,0,321,62,1,0,0,0,322,323,
		5,99,0,0,323,324,5,97,0,0,324,325,5,115,0,0,325,326,5,116,0,0,326,64,1,
		0,0,0,327,328,5,101,0,0,328,329,5,120,0,0,329,330,5,112,0,0,330,331,5,
		114,0,0,331,66,1,0,0,0,332,333,5,116,0,0,333,334,5,101,0,0,334,335,5,114,
		0,0,335,336,5,109,0,0,336,68,1,0,0,0,337,338,5,102,0,0,338,339,5,97,0,
		0,339,340,5,99,0,0,340,341,5,116,0,0,341,342,5,111,0,0,342,343,5,114,0,
		0,343,70,1,0,0,0,344,345,5,100,0,0,345,346,5,101,0,0,346,347,5,115,0,0,
		347,348,5,105,0,0,348,349,5,103,0,0,349,350,5,110,0,0,350,351,5,97,0,0,
		351,352,5,116,0,0,352,353,5,111,0,0,353,354,5,114,0,0,354,72,1,0,0,0,355,
		356,5,115,0,0,356,357,5,116,0,0,357,358,5,114,0,0,358,359,5,105,0,0,359,
		360,5,110,0,0,360,361,5,103,0,0,361,74,1,0,0,0,362,363,5,99,0,0,363,364,
		5,104,0,0,364,365,5,97,0,0,365,366,5,114,0,0,366,76,1,0,0,0,367,368,5,
		110,0,0,368,369,5,117,0,0,369,370,5,109,0,0,370,371,5,98,0,0,371,372,5,
		101,0,0,372,373,5,114,0,0,373,78,1,0,0,0,374,375,5,58,0,0,375,80,1,0,0,
		0,376,377,5,45,0,0,377,82,1,0,0,0,378,379,5,43,0,0,379,84,1,0,0,0,380,
		381,5,45,0,0,381,86,1,0,0,0,382,383,5,42,0,0,383,88,1,0,0,0,384,385,5,
		47,0,0,385,90,1,0,0,0,386,387,5,37,0,0,387,92,1,0,0,0,388,389,5,38,0,0,
		389,390,5,38,0,0,390,94,1,0,0,0,391,392,5,124,0,0,392,393,5,124,0,0,393,
		96,1,0,0,0,394,395,5,63,0,0,395,98,1,0,0,0,396,397,5,43,0,0,397,398,5,
		61,0,0,398,100,1,0,0,0,399,400,5,43,0,0,400,401,5,43,0,0,401,102,1,0,0,
		0,402,403,5,45,0,0,403,404,5,45,0,0,404,104,1,0,0,0,405,406,5,46,0,0,406,
		106,1,0,0,0,407,408,5,61,0,0,408,108,1,0,0,0,409,410,5,45,0,0,410,411,
		5,61,0,0,411,110,1,0,0,0,412,413,5,42,0,0,413,414,5,61,0,0,414,112,1,0,
		0,0,415,416,5,47,0,0,416,417,5,61,0,0,417,114,1,0,0,0,418,419,5,37,0,0,
		419,420,5,61,0,0,420,116,1,0,0,0,421,422,5,61,0,0,422,423,5,61,0,0,423,
		118,1,0,0,0,424,425,5,33,0,0,425,426,5,61,0,0,426,120,1,0,0,0,427,428,
		5,33,0,0,428,122,1,0,0,0,429,430,5,60,0,0,430,124,1,0,0,0,431,432,5,62,
		0,0,432,126,1,0,0,0,433,434,5,60,0,0,434,435,5,61,0,0,435,128,1,0,0,0,
		436,437,5,62,0,0,437,438,5,61,0,0,438,130,1,0,0,0,439,440,5,116,0,0,440,
		441,5,114,0,0,441,442,5,117,0,0,442,443,5,101,0,0,443,132,1,0,0,0,444,
		445,5,102,0,0,445,446,5,97,0,0,446,447,5,108,0,0,447,448,5,115,0,0,448,
		449,5,101,0,0,449,134,1,0,0,0,450,451,5,110,0,0,451,452,5,101,0,0,452,
		453,5,119,0,0,453,136,1,0,0,0,454,458,5,34,0,0,455,457,9,0,0,0,456,455,
		1,0,0,0,457,460,1,0,0,0,458,459,1,0,0,0,458,456,1,0,0,0,459,461,1,0,0,
		0,460,458,1,0,0,0,461,462,5,34,0,0,462,138,1,0,0,0,463,465,3,145,72,0,
		464,463,1,0,0,0,465,466,1,0,0,0,466,464,1,0,0,0,466,467,1,0,0,0,467,474,
		1,0,0,0,468,470,3,105,52,0,469,471,3,145,72,0,470,469,1,0,0,0,471,472,
		1,0,0,0,472,470,1,0,0,0,472,473,1,0,0,0,473,475,1,0,0,0,474,468,1,0,0,
		0,474,475,1,0,0,0,475,140,1,0,0,0,476,481,3,143,71,0,477,480,3,143,71,
		0,478,480,3,145,72,0,479,477,1,0,0,0,479,478,1,0,0,0,480,483,1,0,0,0,481,
		479,1,0,0,0,481,482,1,0,0,0,482,142,1,0,0,0,483,481,1,0,0,0,484,486,7,
		0,0,0,485,484,1,0,0,0,486,144,1,0,0,0,487,488,7,1,0,0,488,146,1,0,0,0,
		489,490,7,2,0,0,490,148,1,0,0,0,491,493,7,3,0,0,492,491,1,0,0,0,493,494,
		1,0,0,0,494,492,1,0,0,0,494,495,1,0,0,0,495,496,1,0,0,0,496,497,6,74,0,
		0,497,150,1,0,0,0,498,499,5,47,0,0,499,500,5,47,0,0,500,504,1,0,0,0,501,
		503,8,4,0,0,502,501,1,0,0,0,503,506,1,0,0,0,504,502,1,0,0,0,504,505,1,
		0,0,0,505,507,1,0,0,0,506,504,1,0,0,0,507,508,6,75,0,0,508,152,1,0,0,0,
		509,510,5,47,0,0,510,511,5,42,0,0,511,515,1,0,0,0,512,514,9,0,0,0,513,
		512,1,0,0,0,514,517,1,0,0,0,515,516,1,0,0,0,515,513,1,0,0,0,516,518,1,
		0,0,0,517,515,1,0,0,0,518,519,5,42,0,0,519,520,5,47,0,0,520,521,1,0,0,
		0,521,522,6,76,0,0,522,154,1,0,0,0,11,0,458,466,472,474,479,481,485,494,
		504,515,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace gen
