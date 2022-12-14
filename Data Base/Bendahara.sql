PGDMP         3                z         	   Bendahara    14.2    14.2                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    25202 	   Bendahara    DATABASE     k   CREATE DATABASE "Bendahara" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_Indonesia.1252';
    DROP DATABASE "Bendahara";
                postgres    false                        2615    25203    keuangan    SCHEMA        CREATE SCHEMA keuangan;
    DROP SCHEMA keuangan;
                postgres    false            ?            1259    25219    anggota    TABLE     ?   CREATE TABLE keuangan.anggota (
    id_anggota integer NOT NULL,
    nama character varying(255) NOT NULL,
    nim character varying(14) NOT NULL,
    gender character varying(10) NOT NULL
);
    DROP TABLE keuangan.anggota;
       keuangan         heap    postgres    false    4            ?            1259    25218    anggota_id_anggota_seq    SEQUENCE     ?   CREATE SEQUENCE keuangan.anggota_id_anggota_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE keuangan.anggota_id_anggota_seq;
       keuangan          postgres    false    210    4                       0    0    anggota_id_anggota_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE keuangan.anggota_id_anggota_seq OWNED BY keuangan.anggota.id_anggota;
          keuangan          postgres    false    209            ?            1259    25233 	   jenis_kas    TABLE     m   CREATE TABLE keuangan.jenis_kas (
    id_jenis integer NOT NULL,
    jenis character varying(10) NOT NULL
);
    DROP TABLE keuangan.jenis_kas;
       keuangan         heap    postgres    false    4            ?            1259    25232    jenis_kas_id_jenis_seq    SEQUENCE     ?   CREATE SEQUENCE keuangan.jenis_kas_id_jenis_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE keuangan.jenis_kas_id_jenis_seq;
       keuangan          postgres    false    212    4                       0    0    jenis_kas_id_jenis_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE keuangan.jenis_kas_id_jenis_seq OWNED BY keuangan.jenis_kas.id_jenis;
          keuangan          postgres    false    211            ?            1259    25280    kas    TABLE       CREATE TABLE keuangan.kas (
    id_kas integer NOT NULL,
    jumlah_uang bigint NOT NULL,
    id_anggota integer NOT NULL,
    id_jenis integer NOT NULL,
    keterangan character varying(255) NOT NULL,
    waktu timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
    DROP TABLE keuangan.kas;
       keuangan         heap    postgres    false    4            ?            1259    25279    kas_id_kas_seq    SEQUENCE     ?   CREATE SEQUENCE keuangan.kas_id_kas_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE keuangan.kas_id_kas_seq;
       keuangan          postgres    false    214    4            	           0    0    kas_id_kas_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE keuangan.kas_id_kas_seq OWNED BY keuangan.kas.id_kas;
          keuangan          postgres    false    213            f           2604    25222    anggota id_anggota    DEFAULT     |   ALTER TABLE ONLY keuangan.anggota ALTER COLUMN id_anggota SET DEFAULT nextval('keuangan.anggota_id_anggota_seq'::regclass);
 C   ALTER TABLE keuangan.anggota ALTER COLUMN id_anggota DROP DEFAULT;
       keuangan          postgres    false    209    210    210            g           2604    25236    jenis_kas id_jenis    DEFAULT     |   ALTER TABLE ONLY keuangan.jenis_kas ALTER COLUMN id_jenis SET DEFAULT nextval('keuangan.jenis_kas_id_jenis_seq'::regclass);
 C   ALTER TABLE keuangan.jenis_kas ALTER COLUMN id_jenis DROP DEFAULT;
       keuangan          postgres    false    212    211    212            h           2604    25283 
   kas id_kas    DEFAULT     l   ALTER TABLE ONLY keuangan.kas ALTER COLUMN id_kas SET DEFAULT nextval('keuangan.kas_id_kas_seq'::regclass);
 ;   ALTER TABLE keuangan.kas ALTER COLUMN id_kas DROP DEFAULT;
       keuangan          postgres    false    214    213    214            ?          0    25219    anggota 
   TABLE DATA           B   COPY keuangan.anggota (id_anggota, nama, nim, gender) FROM stdin;
    keuangan          postgres    false    210   ?       ?          0    25233 	   jenis_kas 
   TABLE DATA           6   COPY keuangan.jenis_kas (id_jenis, jenis) FROM stdin;
    keuangan          postgres    false    212   ?                  0    25280    kas 
   TABLE DATA           ]   COPY keuangan.kas (id_kas, jumlah_uang, id_anggota, id_jenis, keterangan, waktu) FROM stdin;
    keuangan          postgres    false    214   ?       
           0    0    anggota_id_anggota_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('keuangan.anggota_id_anggota_seq', 19, true);
          keuangan          postgres    false    209                       0    0    jenis_kas_id_jenis_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('keuangan.jenis_kas_id_jenis_seq', 3, true);
          keuangan          postgres    false    211                       0    0    kas_id_kas_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('keuangan.kas_id_kas_seq', 27, true);
          keuangan          postgres    false    213            k           2606    25224    anggota anggota_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY keuangan.anggota
    ADD CONSTRAINT anggota_pkey PRIMARY KEY (id_anggota);
 @   ALTER TABLE ONLY keuangan.anggota DROP CONSTRAINT anggota_pkey;
       keuangan            postgres    false    210            m           2606    25238    jenis_kas jenis_kas_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY keuangan.jenis_kas
    ADD CONSTRAINT jenis_kas_pkey PRIMARY KEY (id_jenis);
 D   ALTER TABLE ONLY keuangan.jenis_kas DROP CONSTRAINT jenis_kas_pkey;
       keuangan            postgres    false    212            o           2606    25286    kas kas_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY keuangan.kas
    ADD CONSTRAINT kas_pkey PRIMARY KEY (id_kas);
 8   ALTER TABLE ONLY keuangan.kas DROP CONSTRAINT kas_pkey;
       keuangan            postgres    false    214            ?     x?m??n?0Ư?S?'X?Ҍ?mNct?7?|?
G?.?h??W]M??4=???O#1G??%MYA?P??㩩?=?"???߻?8??b?v???4.?R?n?H$?l??;H]&?n???\?[fд?Om??~ >벑?.[A?:ð??5K??X?J?RV??&?+??у?Y??`҇??\3ԥ????;??v?E????D???26G??Ckޣq?????ͣ?J??)xx?FWɴ?-%-??Z??$;4?K?졝y?9ۼx??J???      ?   (   x?3?H?M,.?N??2??N?)M,?2??N,?????? ???            x???MN1?ur??@#?;??\??&?.?t*u??'?Cj+1%???q?? :P?ŉ{Zm^?w۵qX??11/??R?ZICN?????9?*?@E??î???o]mV??[f?5?R<??#ˎ?r;N???v???P?i?U????Ur&????sz?9Ǖb???X??0?~???m=|??o?a??Rd??a???l	I=??Jg?p??D???????w?G%@YL?1M9??/(]????K)??z??????C	9?B????G???     