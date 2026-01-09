class Badge {
    public String print(Integer id, String name, String department) {
        String idPart = (id == null) ? "" : "[" + id + "] - ";
        String deptPart = (department == null) ? "OWNER" : department.toUpperCase();
        return idPart + name + " - " + deptPart;
    }
}
