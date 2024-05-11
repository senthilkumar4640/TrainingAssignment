PGDMP          
    
        |            OnlineLibraryManagement    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16657    OnlineLibraryManagement    DATABASE     �   CREATE DATABASE "OnlineLibraryManagement" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
 )   DROP DATABASE "OnlineLibraryManagement";
                postgres    false            �            1259    16668    bookDetails    TABLE     �   CREATE TABLE public."bookDetails" (
    "BookID" integer NOT NULL,
    "BookName" character varying(250) NOT NULL,
    "AuthorName" character varying(250) NOT NULL,
    "BookCount" integer,
    "Images" text[]
);
 !   DROP TABLE public."bookDetails";
       public         heap    postgres    false            �            1259    16667    bookDetails_BookID_seq    SEQUENCE     �   CREATE SEQUENCE public."bookDetails_BookID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."bookDetails_BookID_seq";
       public          postgres    false    216            �           0    0    bookDetails_BookID_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."bookDetails_BookID_seq" OWNED BY public."bookDetails"."BookID";
          public          postgres    false    215            �            1259    16677    borrowDetails    TABLE     �   CREATE TABLE public."borrowDetails" (
    "BorrowID" integer NOT NULL,
    "BookID" integer,
    "UserID" integer,
    "BorrowedDate" date,
    "BorrowBookCount" integer,
    "Status" character varying(250),
    "PaidFineAmount" integer
);
 #   DROP TABLE public."borrowDetails";
       public         heap    postgres    false            �            1259    16676    borrowDetails_BorrowID_seq    SEQUENCE     �   CREATE SEQUENCE public."borrowDetails_BorrowID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public."borrowDetails_BorrowID_seq";
       public          postgres    false    218            �           0    0    borrowDetails_BorrowID_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public."borrowDetails_BorrowID_seq" OWNED BY public."borrowDetails"."BorrowID";
          public          postgres    false    217            �            1259    16684    userDetails    TABLE     �  CREATE TABLE public."userDetails" (
    "UserID" integer NOT NULL,
    "UserName" character varying(250) NOT NULL,
    "Gender" character varying(250) NOT NULL,
    "Department" character varying(250) NOT NULL,
    "MobileNumber" character varying(250) NOT NULL,
    "MailID" character varying(250) NOT NULL,
    "Password" character varying(250) NOT NULL,
    "WalletBalance" numeric(10,2)
);
 !   DROP TABLE public."userDetails";
       public         heap    postgres    false            �            1259    16683    userDetails_UserID_seq    SEQUENCE     �   CREATE SEQUENCE public."userDetails_UserID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."userDetails_UserID_seq";
       public          postgres    false    220                        0    0    userDetails_UserID_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."userDetails_UserID_seq" OWNED BY public."userDetails"."UserID";
          public          postgres    false    219            Z           2604    16671    bookDetails BookID    DEFAULT     ~   ALTER TABLE ONLY public."bookDetails" ALTER COLUMN "BookID" SET DEFAULT nextval('public."bookDetails_BookID_seq"'::regclass);
 E   ALTER TABLE public."bookDetails" ALTER COLUMN "BookID" DROP DEFAULT;
       public          postgres    false    215    216    216            [           2604    16680    borrowDetails BorrowID    DEFAULT     �   ALTER TABLE ONLY public."borrowDetails" ALTER COLUMN "BorrowID" SET DEFAULT nextval('public."borrowDetails_BorrowID_seq"'::regclass);
 I   ALTER TABLE public."borrowDetails" ALTER COLUMN "BorrowID" DROP DEFAULT;
       public          postgres    false    218    217    218            \           2604    16687    userDetails UserID    DEFAULT     ~   ALTER TABLE ONLY public."userDetails" ALTER COLUMN "UserID" SET DEFAULT nextval('public."userDetails_UserID_seq"'::regclass);
 E   ALTER TABLE public."userDetails" ALTER COLUMN "UserID" DROP DEFAULT;
       public          postgres    false    219    220    220            �          0    16668    bookDetails 
   TABLE DATA           b   COPY public."bookDetails" ("BookID", "BookName", "AuthorName", "BookCount", "Images") FROM stdin;
    public          postgres    false    216   �       �          0    16677    borrowDetails 
   TABLE DATA           �   COPY public."borrowDetails" ("BorrowID", "BookID", "UserID", "BorrowedDate", "BorrowBookCount", "Status", "PaidFineAmount") FROM stdin;
    public          postgres    false    218          �          0    16684    userDetails 
   TABLE DATA           �   COPY public."userDetails" ("UserID", "UserName", "Gender", "Department", "MobileNumber", "MailID", "Password", "WalletBalance") FROM stdin;
    public          postgres    false    220   @                  0    0    bookDetails_BookID_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."bookDetails_BookID_seq"', 5, true);
          public          postgres    false    215                       0    0    borrowDetails_BorrowID_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public."borrowDetails_BorrowID_seq"', 17, true);
          public          postgres    false    217                       0    0    userDetails_UserID_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."userDetails_UserID_seq"', 1, true);
          public          postgres    false    219            ^           2606    16675    bookDetails bookDetails_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public."bookDetails"
    ADD CONSTRAINT "bookDetails_pkey" PRIMARY KEY ("BookID");
 J   ALTER TABLE ONLY public."bookDetails" DROP CONSTRAINT "bookDetails_pkey";
       public            postgres    false    216            `           2606    16682     borrowDetails borrowDetails_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."borrowDetails"
    ADD CONSTRAINT "borrowDetails_pkey" PRIMARY KEY ("BorrowID");
 N   ALTER TABLE ONLY public."borrowDetails" DROP CONSTRAINT "borrowDetails_pkey";
       public            postgres    false    218            b           2606    16691    userDetails userDetails_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public."userDetails"
    ADD CONSTRAINT "userDetails_pkey" PRIMARY KEY ("UserID");
 J   ALTER TABLE ONLY public."userDetails" DROP CONSTRAINT "userDetails_pkey";
       public            postgres    false    220            �      x������ � �      �   )   x�34�4�4�4202�5 " �)��(�<5�Ӏ+F��� I      �   I   x�3�N�+����.�M,��M�I�tv崰02�04�42�,�(pH�M���K���4NC=�=... {     