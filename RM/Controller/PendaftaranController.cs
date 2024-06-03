using RM.Model.Entity;
using RM.Model.Repository;
using RM.View;
using System.Windows.Forms;

namespace RM.Controller
{
    public class PendaftaranController
    {
        private MemberRepository memberRepository;

        public PendaftaranController(MemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }

        public void DaftarMember(string nomorTelepon, string nama)
        {
            Member newMember = new Member
            {
                NomorTelepon = nomorTelepon,
                Nama = nama
            };
            // method Create dari MemberRepository
            bool success = memberRepository.Create(newMember);

            if (success)
            {
                MessageBox.Show("Pendaftaran member berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pendaftaran member gagal. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
