parser grammar MiniCParser;

options {
  tokenVocab = MiniCScanner;
}

program: usingDeclaration? classDeclaration* EOF;

usingDeclaration: Using ident Semicolon;

classDeclaration: Class ident Lbrace memberDeclaration* Rbrace;

memberDeclaration: varDeclaration | methodDeclaration | classDeclaration;

varDeclaration: type ident (Comma ident)* Semicolon;

methodDeclaration: (type|Void) ID Lparen formPars? Rparen block;

formPars: parameter (Comma parameter)*;

parameter: type ident;

type: ident  (LList ident? RList)*;

block:  Lbrace (statement|varDeclaration)* Rbrace;

statement: 
     designator (Assign expression | Lparen actPars? Rparen | PlusPlus | MinusMinus) Semicolon |
     ifStatement        | 
     forStatement       | 
     whileStatement     |
     Break Semicolon    |
     returnStatement    | 
     readStatement      |
     writeStatement     |
     addStatement       |
     delStatement       |
     lenStatement       |
     block              | 
     Semicolon;

addStatement: Add Lparen designator (Comma (PLAIN_TEXT | ID | NUM )) Rparen Semicolon;

delStatement: Del Lparen designator Comma expression Rparen Semicolon;

lenStatement: Len Lparen designator Rparen Semicolon;

ifStatement: If Lparen condition Rparen statement (Else statement)?;

forStatement: For Lparen expressionStatement varDeclaration* condition* Rparen statement;

whileStatement: While Lparen condition Rparen statement; // NO SE SI ES EXPRESSION O USAR CONDITIONALEXPRESSION

returnStatement: Return expression? Semicolon;

readStatement: Read Lparen designator Rparen Semicolon;

writeStatement: Write Lparen (expression | PLAIN_TEXT) (Comma expression | PLAIN_TEXT)? Rparen Semicolon;

expressionStatement: expression Semicolon;

actPars: expression (Comma expression)*;

designator: ID (LList expression RList | DOT ID)*;

condition   : condTerm (LogicalOr condTerm)*;
condTerm : condFact (LogicalAnd condFact)*;
condFact : expression relop expression;
cast: Lparen type Rparen;
expression: Dash? cast? term (addop term)*; 
//en factor el type de 'new type' no se puede
factor: designator (Lparen actPars Rparen)? | NUM | CharConst | StringConst | (False | True) | PLAIN_TEXT | (New type) | (Lparen expression Rparen);
term: factor (mulop factor)*;
mulop : Mult | Div | Mod;
addop: Plus | Minus;
relop: LessThan | LessThanOrEquals | GreaterThan | GreaterThanOrEquals;
ident: ID (LList RList)*;
