lexer grammar MiniCScanner;
Using : 'using';
Class : 'class';
VarDecl : 'varDecl';
ClassDecl : 'classDecl';
MethodDecl : 'methodDecl';
Type : 'type';
Void : 'Void';
Statement : 'statement';
Semicolon: ';';
Lbrace: '{';
Rbrace: '}';
Lparen: '(';
Rparen: ')';
LList: '[';
RList: ']';
Comma:',';
If : 'if';
Else : 'else';
For : 'for';
While : 'while';
Break : 'break';
Return : 'return';
Read : 'read';
Write : 'write';
//Block : 'block';
ActPars : 'actPars';
Condition : 'condition';
CondTerm : 'condTerm';
CondFact : 'condFact';
Cast : 'cast';
Expr : 'expr';
Term : 'term';
Factor : 'factor';
Designator : 'designator';
//Ident : 'ident';
StringConst : 'string';
CharConst : 'char';
Number : 'number';
Colon : ':';
Dash: '-';
Plus: '+';
Minus: '-';
Mult: '*';
Div: '/';
Mod: '%';
LogicalAnd: '&&';
LogicalOr: '||';
QuestionMark: '?';
PlusEquals:'+=';
PlusPlus: '++';
MinusMinus: '--';
DOT: '.';
Assign: '=';
MinusEquals:'-='; 
MultEquals:'*='; 
DivEquals:'/=';
ModEquals:'%=';
Equals: '==';
NotEquals: '!=';
LogicalNot: '!';
LessThan: '<';
GreaterThan: '>';
LessThanOrEquals: '<=';
GreaterThanOrEquals: '>=';
True: 'true';
False: 'false';
New: 'new';

PLAIN_TEXT : '"' (LETTER|NUM| SPECIAL |WS)* '"';

//FIN DE TAREAS PALABRAS RESERVADAS
NUM     : DIGIT+ (DOT DIGIT+)?;

ID      : LETTER (LETTER|DIGIT)*;
fragment LETTER  : [a-z]|[A-Z];
fragment DIGIT   : [0-9];
fragment SPECIAL  : [\p{P}\p{S}];

WS      : [ \t\n\r]+ -> skip ;
COMMENT : '//' ~[\r\n]* -> skip;
MULTIPLE_COMMENT: '/*' ~[\r\n]* '*/' -> skip;
