DROP TABLE BOOKINGS;
DROP TABLE CLASSES;
DROP TABLE INSTRUCTORS;
DROP TABLE CLASS_TYPES;
DROP TABLE MEMBERS;

PROMPT CREATING Table MEMBERS
PROMPT
CREATE TABLE MEMBERS
(Member_ID numeric(5),
Firstname varchar2(25) NOT NULL,
Lastname varchar2(25) NOT NULL,
Gender varchar2(8) NOT NULL,
Email varchar2(50) NOT NULL,
Phone numeric(12) NOT NULL,
DOB DATE NOT NULL,
Password varchar2(20) NOT NULL,
CONSTRAINT pk_Members PRIMARY KEY (Member_ID));

PROMPT CREATING Table CLASS_TYPES
PROMPT
CREATE TABLE CLASS_TYPES
(Type_ID varchar2(2),
Type varchar2(10) NOT NULL,
Qty_of_classes numeric(3),
CONSTRAINT pk_CLASS_TYPES PRIMARY KEY (Type_ID));

PROMPT CREATING Table INSTRUCTORS
PROMPT
CREATE TABLE INSTRUCTORS
(Instructor_ID numeric(5),
FullName varchar2(50) NOT NULL,
Email varchar2(50) NOT NULL,
Phone numeric(13) NOT NULL,
CONSTRAINT pk_Instructors PRIMARY KEY (Instructor_ID));

PROMPT CREATING Table CLASSES
PROMPT
CREATE TABLE CLASSES
(Class_ID numeric(5),
Name varchar2(30) NOT NULL,
DateCode DATE NOT NULL,
TimeCode varchar2(6) NOT NULL,
AvaliablePlaces numeric(2) NOT NULL,
Capacity numeric(2) NOT NULL,
Price numeric(5,2) CHECK (Price > 0) NOT NULL,
Instructor_ID numeric(5),
Type_ID varchar2(2),  
CONSTRAINT pk_Classes PRIMARY KEY (Class_ID),
CONSTRAINT fk_Classes_Instructors FOREIGN KEY (Instructor_ID) REFERENCES Instructors,
CONSTRAINT fk_Classes_ClassTypes FOREIGN KEY (Type_ID) REFERENCES Class_Types);

PROMPT CREATING Table BOOKINGS
PROMPT
CREATE TABLE BOOKINGS
(
Booking_ID numeric(5),
Card_holder varchar2(25) NOT NULL,
Card_number varchar2(16) NOT NULL,
Payment_date DATE NOT NULL,
Price numeric(5,2) NOT NULL CHECK (Price > 0),
Member_ID numeric(5), 
Class_ID numeric(5),   
CONSTRAINT pk_Bookings PRIMARY KEY (Booking_ID),
CONSTRAINT fk_Bookings_Members FOREIGN KEY (Member_ID) REFERENCES Members,
CONSTRAINT fk_Bookings_Classes FOREIGN KEY (Class_ID) REFERENCES Classes
);

INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(1, 'Mishel', 'Keen', 'Male', 'admin1@gmail.com', 1234567890, TO_DATE('1990-01-15', 'YYYY-MM-DD'), 'password123');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(2, 'John', 'Doe', 'Male', 'admin2@gmail.com', 1234567890, TO_DATE('1995-05-09', 'YYYY-MM-DD'), 'password123');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(3, 'Jane', 'Doe', 'Female', 'admin3@gmail.com', 1234567890, TO_DATE('1990-01-15', 'YYYY-MM-DD'), 'password123');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(4, 'Alice', 'Johnson', 'Female', 'alice.johnson@email.com', 1112223333, TO_DATE('1988-09-05', 'YYYY-MM-DD'), 'alicepass');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(5, 'Charlie', 'Brown', 'Male', 'charlie.brown@email.com', 4445556666, TO_DATE('1992-11-20', 'YYYY-MM-DD'), 'charlie123');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(6, 'Eva', 'Miller', 'Female', 'eva.miller@email.com', 9998887777, TO_DATE('1980-03-12', 'YYYY-MM-DD'), 'evapwd');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(7, 'David', 'Smith', 'Male', 'david.smith@email.com', 7778889999, TO_DATE('1982-07-18', 'YYYY-MM-DD'), 'davidpass');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(8, 'Sophie', 'Anderson', 'Female', 'sophie.anderson@email.com', 1239874560, TO_DATE('1993-05-25', 'YYYY-MM-DD'), 'sophie456');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(9, 'Michael', 'Jones', 'Male', 'michael.jones@email.com', 5554443333, TO_DATE('1975-12-03', 'YYYY-MM-DD'), 'mikepwd');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(10, 'John', 'Doe', 'Male', 'john.doe@email.com', 1234567890, TO_DATE('1990-01-15', 'YYYY-MM-DD'), 'password123');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(12, 'Jane', 'Smith', 'Female', 'jane.smith@email.com', 9876543210, TO_DATE('1985-08-22', 'YYYY-MM-DD'), 'pass456');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(13, 'Bob', 'Johnson', 'Male', 'bob.johnson@email.com', 5556667777, TO_DATE('1995-04-10', 'YYYY-MM-DD'), 'secret789');
INSERT INTO MEMBERS (Member_ID, Firstname, Lastname, Gender, Email, Phone, DOB, Password)
VALUES(14, 'Anna', 'Kovalenko', 'Male', 'anna@gmail.com', 5556667777, TO_DATE('2005-08-10', 'YYYY-MM-DD'), '12312312');

INSERT INTO CLASS_TYPES (Type_ID, Type, Qty_of_classes)
VALUES('YO', 'Yoga', 4);
INSERT INTO CLASS_TYPES (Type_ID, Type, Qty_of_classes)
VALUES('PI', 'Pilates', 4);
INSERT INTO CLASS_TYPES (Type_ID, Type, Qty_of_classes)
VALUES('ZU', 'Zumba', 0);
INSERT INTO CLASS_TYPES (Type_ID, Type, Qty_of_classes)
VALUES('KP', 'K-pop', 1);
INSERT INTO CLASS_TYPES (Type_ID, Type, Qty_of_classes)
VALUES('SP', 'Spin', 3);
INSERT INTO CLASS_TYPES (Type_ID, Type, Qty_of_classes)
VALUES('BA','Ballet', 3);
INSERT INTO CLASS_TYPES (Type_ID, Type, Qty_of_classes)
VALUES('HI','Hiit', 0);
INSERT INTO CLASS_TYPES (Type_ID, Type, Qty_of_classes)
VALUES('ST','Strength', 0);
INSERT INTO CLASS_TYPES (Type_ID, Type, Qty_of_classes)
VALUES('CY','Cycling', 0);

INSERT INTO INSTRUCTORS (Instructor_ID, FullName, Email, Phone)
VALUES(1, 'John Smith', 'john.smith@example.com', 1234567890123);
INSERT INTO INSTRUCTORS (Instructor_ID, FullName, Email, Phone)
VALUES(2, 'Jane Doe', 'jane.doe@example.com', 2345678901234);
INSERT INTO INSTRUCTORS (Instructor_ID, FullName, Email, Phone)
VALUES(3, 'Bob Johnson', 'bob.johnson@example.com', 3456789012345);
INSERT INTO INSTRUCTORS (Instructor_ID, FullName, Email, Phone)
VALUES(4, 'Alice Williams', 'alice.williams@example.com', 4567890123456);
INSERT INTO INSTRUCTORS (Instructor_ID, FullName, Email, Phone)
VALUES(5, 'Charlie Brown', 'charlie.brown@example.com', 5678901234567);

INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(1, 'Yoga Flow', TO_DATE('2024-08-01', 'YYYY-MM-DD'), '09:00', 20, 20, 20, 1, 'Yo');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(2, 'Yoga Basics 1', TO_DATE('2024-09-02', 'YYYY-MM-DD'), '10:30', 20, 20, 15, 2, 'YO');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(3, 'Pilates Reformer', TO_DATE('2024-09-01', 'YYYY-MM-DD'), '12:00', 10, 10, 30, 3, 'PI');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(4, 'Pilates Mat', TO_DATE('2024-09-03', 'YYYY-MM-DD'), '09:30', 15, 15, 20, 4, 'PI');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(5, 'Spinning', TO_DATE('2024-09-01', 'YYYY-MM-DD'), '16:00', 20, 20, 25, 5, 'SP');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(6, 'Spin Class 2', TO_DATE('2024-09-02', 'YYYY-MM-DD'), '17:30', 15, 15, 20, 2, 'SP');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(7, 'Ballet Basics', TO_DATE('2024-05-01', 'YYYY-MM-DD'), '11:00', 20, 20, 20, 1, 'BA');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(8, 'Ballet Intermediate', TO_DATE('2024-05-03', 'YYYY-MM-DD'), '16:30', 15, 15, 22, 2, 'BA');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(9, 'Ballet Beginners', TO_DATE('2024-05-02', 'YYYY-MM-DD'), '14:00', 12, 12, 28, 4, 'BA');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(10, 'Yoga for Beginners', TO_DATE('2024-05-22', 'YYYY-MM-DD'), '14:30', 22, 22, 12, 5, 'YO');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(11, 'Yoga Weekend Retreat', TO_DATE('2024-02-25', 'YYYY-MM-DD'), '10:00', 20, 20, 30, 1, 'YO');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(12, 'Pilates for Beginners', TO_DATE('2024-06-28', 'YYYY-MM-DD'), '13:45', 18, 18, 16, 3, 'PI');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(13, 'Pilates for Intermediate', TO_DATE('2024-06-02', 'YYYY-MM-DD'), '17:15', 15, 15, 24, 2, 'PI');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(14, 'Spin Class', TO_DATE('2024-07-05', 'YYYY-MM-DD'), '16:00', 25, 25, 14, 5, 'SP');
INSERT INTO CLASSES (Class_ID, Name, DateCode, TimeCode, AvaliablePlaces, Capacity, Price, Instructor_ID, Type_ID)
VALUES(15, 'K-pop Dance Marathon', TO_DATE('2024-08-08', 'YYYY-MM-DD'), '14:30', 12, 12, 26, 4, 'KP');

INSERT INTO BOOKINGS (Booking_ID, Card_holder, Card_number, Payment_date, Price, Member_ID, Class_ID)
VALUES(1, 'John Doe', 1234567890123456, TO_DATE('2024-02-02', 'YYYY-MM-DD'), 20, 1, 1);
INSERT INTO BOOKINGS (Booking_ID, Card_holder, Card_number, Payment_date, Price, Member_ID, Class_ID)
VALUES(2, 'Jane Smith', 9876543210987654, TO_DATE('2024-02-04', 'YYYY-MM-DD'), 25, 2, 2);
INSERT INTO BOOKINGS (Booking_ID, Card_holder, Card_number, Payment_date, Price, Member_ID, Class_ID)
VALUES(3, 'Bob Johnson', 1111222233334444, TO_DATE('2024-02-06', 'YYYY-MM-DD'), 15, 3, 3);
INSERT INTO BOOKINGS (Booking_ID, Card_holder, Card_number, Payment_date, Price, Member_ID, Class_ID)
VALUES(4, 'Alice Johnson', 5555666677778888, TO_DATE('2024-02-09', 'YYYY-MM-DD'), 30, 4, 4);
INSERT INTO BOOKINGS (Booking_ID, Card_holder, Card_number, Payment_date, Price, Member_ID, Class_ID)
VALUES(5, 'Charlie Brown', 9999888877776666, TO_DATE('2024-02-11', 'YYYY-MM-DD'), 10, 5, 5);
INSERT INTO BOOKINGS (Booking_ID, Card_holder, Card_number, Payment_date, Price, Member_ID, Class_ID)
VALUES(6, 'Eva Miller', 3333444455556666, TO_DATE('2024-02-14', 'YYYY-MM-DD'), 18, 1, 6);
INSERT INTO BOOKINGS (Booking_ID, Card_holder, Card_number, Payment_date, Price, Member_ID, Class_ID)
VALUES(7, 'David Smith', 7777888899990000, TO_DATE('2024-02-17', 'YYYY-MM-DD'), 17, 2, 7);
INSERT INTO BOOKINGS (Booking_ID, Card_holder, Card_number, Payment_date, Price, Member_ID, Class_ID)
VALUES(8, 'Sophie Anderson', 1234987650123456, TO_DATE('2024-02-19', 'YYYY-MM-DD'), 22, 3, 8);
INSERT INTO BOOKINGS (Booking_ID, Card_holder, Card_number, Payment_date, Price, Member_ID, Class_ID)
VALUES(9, 'Michael Jones', 5555444433332222, TO_DATE('2024-02-22', 'YYYY-MM-DD'), 28, 4, 9);
INSERT INTO BOOKINGS (Booking_ID, Card_holder, Card_number, Payment_date, Price, Member_ID, Class_ID)
VALUES(10, 'Alice Johnson', 1111222233445566, TO_DATE('2024-02-24', 'YYYY-MM-DD'), 12, 5, 10);

COMMIT;