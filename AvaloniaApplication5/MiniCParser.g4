parser grammar MiniCParser;

options {
  tokenVocab = MiniCScanner;
}

// Parser rules

program: usingDeclaration? classDeclaration* EOF;

usingDeclaration: Using ID Semicolon;

classDeclaration: Class ID Lbrace memberDeclaration* Rbrace;

memberDeclaration: varDeclaration | methodDeclaration | classDeclaration;

varDeclaration: VarDecl type ID (Lbrace NUM Rbrace)* Semicolon;

methodDeclaration: MethodDecl type ID Lparen parameterList? Rparen block;

parameterList: parameter (Comma parameter)*;
parameter: type ID (Lbrace Rbrace)*;

type: Type | ID;

block: Lbrace statement* Rbrace;

statement: 
     designator (Assign expression | Lparen argumentList? Rparen | PlusPlus | MinusMinus) |
     block              | 
     ifStatement        | 
     whileStatement     |
     forStatement       | 
     returnStatement    | 
     readStatement      |
     writeStatement     |
     expressionStatement|
     Semicolon;

ifStatement: If Lparen expression Rparen statement (Else statement)?;

whileStatement: While Lparen expression Rparen statement;

forStatement: For Lparen forControl Rparen statement;

forControl: varDeclaration | expressionStatement |;

returnStatement: Return expression? Semicolon;

readStatement: Read Lparen designator Rparen Semicolon;

writeStatement: Write Lparen (expression | PLAIN_TEXT) (Comma expression | PLAIN_TEXT)* Rparen Semicolon;

expressionStatement: expression Semicolon;

expression: assignmentExpression;

assignmentExpression: conditionalExpression (assignmentOperator conditionalExpression)?;

assignmentOperator:  Equals         |
                     PlusEquals     | 
                     MinusEquals    | 
                     MultEquals     | 
                     DivEquals      | 
                     ModEquals;

conditionalExpression: logicalOrExpression (QuestionMark expression Colon conditionalExpression)?;

logicalOrExpression: logicalAndExpression (LogicalOr logicalAndExpression)*;

logicalAndExpression: equalityExpression (LogicalAnd equalityExpression)*;

equalityExpression: relationalExpression ((Equals | NotEquals) relationalExpression)*;

relationalExpression: additiveExpression ((LessThan | LessThanOrEquals | GreaterThan | GreaterThanOrEquals) additiveExpression)*;

additiveExpression: multiplicativeExpression ((Plus | Minus) multiplicativeExpression)*;

multiplicativeExpression: castExpression ((Mult | Div | Mod) castExpression)*;

castExpression: unaryExpression | Lparen type Rparen castExpression;

unaryExpression: postfixExpression | PlusPlus unaryExpression | MinusMinus unaryExpression | unaryOperator castExpression;

postfixExpression: primaryExpression (Lbrace expression Rbrace | Lparen argumentList? Rparen | DOT ID | PlusPlus | MinusMinus)*;

argumentList: expression (Comma expression)*;

primaryExpression: designator | methodInvocation | Lparen expression Rparen | ID | number | charConst | PLAIN_TEXT;

designator: ID (Lbrace expression Rbrace | DOT ID)*;

methodInvocation: ID Lparen argumentList? Rparen;

number: NUM;

charConst: CharConst;


unaryOperator: Plus | Minus | LogicalNot;
