lexer grammar MiniCScanner;
Using : 'using';
Class : 'class';
VarDecl : 'varDecl';
ClassDecl : 'classDecl';
MethodDecl : 'methodDecl';
Type : 'type';
Statement : 'statement';
Semicolon: ';';
Lbrace: '{';
Rbrace: '}';
Lparen: '(';
Rparen: ')';
Comma:',';
If : 'if';
Else : 'else';
For : 'for';
While : 'while';
Break : 'break';
Return : 'return';
Read : 'read';
Write : 'write';
Block : 'block';
ActPars : 'actPars';
Condition : 'condition';
CondTerm : 'condTerm';
CondFact : 'condFact';
Cast : 'cast';
Expr : 'expr';
Term : 'term';
Factor : 'factor';
Designator : 'designator';
Ident : 'ident';
StringConst : 'string';
CharConst : 'char';
Number : 'number';
Colon : ':';
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

PLAIN_TEXT : '"' (LETTER|DIGIT|WS)* '"';

//FIN DE TAREAS PALABRAS RESERVADAS
NUM     : DIGIT+;
ID      : LETTER (LETTER|DIGIT)*;
fragment LETTER  : [a-z]|[A-Z];
fragment DIGIT   : [0-9];

COMMENT : '//' ~[\r\n]* -> skip;
WS      : [ \t\n\r]+ -> skip ;