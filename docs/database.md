
-- Create Book table
CREATE TABLE Book (
    book_id INT PRIMARY KEY,
    title VARCHAR(255),
    author_id INT,
    category_id INT,
    ISBN VARCHAR(255),
    publication_date DATE,
    available_quantity INT,
    -- Additional columns as needed
    CONSTRAINT FK_Book_Author FOREIGN KEY (author_id) REFERENCES Author(author_id),
    CONSTRAINT FK_Book_Category FOREIGN KEY (category_id) REFERENCES Category(category_id)
);

-- Create Author table
CREATE TABLE Author (
    author_id INT PRIMARY KEY,
    name VARCHAR(255),
    biography VARCHAR(MAX)
    -- Additional columns as needed
);

-- Create Category table
CREATE TABLE Category (
    category_id INT PRIMARY KEY,
    name VARCHAR(255),
    description VARCHAR(MAX)
    -- Additional columns as needed
);

-- Create Member table
CREATE TABLE Member (
    member_id INT PRIMARY KEY,
    name VARCHAR(255),
    address VARCHAR(255),
    email VARCHAR(255),
    phone_number VARCHAR(20)
    -- Additional columns as needed
);

-- Create Loan table
CREATE TABLE Loan (
    loan_id INT PRIMARY KEY,
    book_id INT,
    member_id INT,
    loan_date DATE,
    return_date DATE,
    -- Additional columns as needed
    CONSTRAINT FK_Loan_Book FOREIGN KEY (book_id) REFERENCES Book(book_id),
    CONSTRAINT FK_Loan_Member FOREIGN KEY (member_id) REFERENCES Member(member_id)
);

-- Create ScannedBook table
CREATE TABLE ScannedBook (
    scanned_book_id INT PRIMARY KEY,
    book_id INT,
    scan_date DATETIME,
    -- Additional columns as needed
    CONSTRAINT FK_ScannedBook_Book FOREIGN KEY (book_id) REFERENCES Book(book_id)
);

-- Create Employee table
CREATE TABLE Employee (
    employee_id INT PRIMARY KEY,
    name VARCHAR(255),
    position VARCHAR(255),
    email VARCHAR(255),
    phone_number VARCHAR(20)
    -- Additional columns as needed
);
