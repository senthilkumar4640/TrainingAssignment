PGDMP  /    #    
    
        |            OnlineMedicalStore    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16569    OnlineMedicalStore    DATABASE     �   CREATE DATABASE "OnlineMedicalStore" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
 $   DROP DATABASE "OnlineMedicalStore";
                postgres    false            �            1259    16605    MedicalInfo    TABLE     �   CREATE TABLE public."MedicalInfo" (
    "MedicineID" integer NOT NULL,
    "MedicineName" character varying(250),
    "MedicineCount" integer,
    "MedicinePrice" numeric(10,2),
    "MedicineExpiryDate" date
);
 !   DROP TABLE public."MedicalInfo";
       public         heap    postgres    false            �            1259    16604    MedicalInfo_MedicineID_seq    SEQUENCE     �   CREATE SEQUENCE public."MedicalInfo_MedicineID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public."MedicalInfo_MedicineID_seq";
       public          postgres    false    218            �           0    0    MedicalInfo_MedicineID_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public."MedicalInfo_MedicineID_seq" OWNED BY public."MedicalInfo"."MedicineID";
          public          postgres    false    217            �            1259    16612    Order    TABLE     �   CREATE TABLE public."Order" (
    "OrderID" integer NOT NULL,
    "MedicineID" integer,
    "UserID" integer,
    "MedicineName" character varying(250),
    "MedicineCount" integer,
    "OrderStatus" character varying(250)
);
    DROP TABLE public."Order";
       public         heap    postgres    false            �            1259    16611    Order_OrderID_seq    SEQUENCE     �   CREATE SEQUENCE public."Order_OrderID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public."Order_OrderID_seq";
       public          postgres    false    220            �           0    0    Order_OrderID_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public."Order_OrderID_seq" OWNED BY public."Order"."OrderID";
          public          postgres    false    219            �            1259    16596    User    TABLE     �   CREATE TABLE public."User" (
    "UserID" integer NOT NULL,
    "UserName" character varying(250) NOT NULL,
    "UserEmail" character varying(250) NOT NULL,
    "UserPassword" character varying(250) NOT NULL,
    "UserBalance" numeric(10,2) NOT NULL
);
    DROP TABLE public."User";
       public         heap    postgres    false            �            1259    16595    User_UserID_seq    SEQUENCE     �   CREATE SEQUENCE public."User_UserID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public."User_UserID_seq";
       public          postgres    false    216                        0    0    User_UserID_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public."User_UserID_seq" OWNED BY public."User"."UserID";
          public          postgres    false    215            [           2604    16608    MedicalInfo MedicineID    DEFAULT     �   ALTER TABLE ONLY public."MedicalInfo" ALTER COLUMN "MedicineID" SET DEFAULT nextval('public."MedicalInfo_MedicineID_seq"'::regclass);
 I   ALTER TABLE public."MedicalInfo" ALTER COLUMN "MedicineID" DROP DEFAULT;
       public          postgres    false    218    217    218            \           2604    16615    Order OrderID    DEFAULT     t   ALTER TABLE ONLY public."Order" ALTER COLUMN "OrderID" SET DEFAULT nextval('public."Order_OrderID_seq"'::regclass);
 @   ALTER TABLE public."Order" ALTER COLUMN "OrderID" DROP DEFAULT;
       public          postgres    false    219    220    220            Z           2604    16599    User UserID    DEFAULT     p   ALTER TABLE ONLY public."User" ALTER COLUMN "UserID" SET DEFAULT nextval('public."User_UserID_seq"'::regclass);
 >   ALTER TABLE public."User" ALTER COLUMN "UserID" DROP DEFAULT;
       public          postgres    false    215    216    216            �          0    16605    MedicalInfo 
   TABLE DATA           }   COPY public."MedicalInfo" ("MedicineID", "MedicineName", "MedicineCount", "MedicinePrice", "MedicineExpiryDate") FROM stdin;
    public          postgres    false    218          �          0    16612    Order 
   TABLE DATA           t   COPY public."Order" ("OrderID", "MedicineID", "UserID", "MedicineName", "MedicineCount", "OrderStatus") FROM stdin;
    public          postgres    false    220   |       �          0    16596    User 
   TABLE DATA           b   COPY public."User" ("UserID", "UserName", "UserEmail", "UserPassword", "UserBalance") FROM stdin;
    public          postgres    false    216   5                  0    0    MedicalInfo_MedicineID_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public."MedicalInfo_MedicineID_seq"', 17, true);
          public          postgres    false    217                       0    0    Order_OrderID_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."Order_OrderID_seq"', 18, true);
          public          postgres    false    219                       0    0    User_UserID_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."User_UserID_seq"', 1, true);
          public          postgres    false    215            `           2606    16610    MedicalInfo MedicalInfo_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."MedicalInfo"
    ADD CONSTRAINT "MedicalInfo_pkey" PRIMARY KEY ("MedicineID");
 J   ALTER TABLE ONLY public."MedicalInfo" DROP CONSTRAINT "MedicalInfo_pkey";
       public            postgres    false    218            b           2606    16619    Order Order_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public."Order"
    ADD CONSTRAINT "Order_pkey" PRIMARY KEY ("OrderID");
 >   ALTER TABLE ONLY public."Order" DROP CONSTRAINT "Order_pkey";
       public            postgres    false    220            ^           2606    16603    User User_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY ("UserID");
 <   ALTER TABLE ONLY public."User" DROP CONSTRAINT "User_pkey";
       public            postgres    false    216            �   i   x�U�M
� @���]�ɴuڶ����������x\C��M��J�d�t�p����I�d���1�g�a�������~��M��Li��D����      �   �   x�}���0�g�aP�(#b���R%�@
�J:���B��6�x���р �����H��Y��c�{rB��p~X �	u�ѷ�KP��#��S��6:ʝ
��gd�:�7��kl2|���?SY�Y��Q׬Ct'jj�fZI�Q���"u^+�,R����U���8!~����      �   j   x�M˻
�0��9}K�������El�V���ת�g��;��v	�b���\1zq��g�6�Ԉ*#h��Z7U���:J��w}�wf��� �冓j�R���-�     