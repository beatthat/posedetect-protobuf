# from distutils.dir_util import copy_tree
import os

# from tempfile import mkdtemp


# def copy_mentor_to_tmp(mentor: str, mentor_data_root: str) -> MentorPath:
#     tmp_mentors = mkdtemp()
#     mpath = MentorPath(mentor_id=mentor, root_path=tmp_mentors)
#     src = os.path.join(mentor_data_root, mentor)
#     tgt = mpath.get_mentor_path()
#     copy_tree(src, tgt)
#     return mpath


def resource_root_for_test(test_file: str) -> str:
    return os.path.abspath(
        os.path.join(
            ".", "tests", "resources", os.path.splitext(os.path.basename(test_file))[0]
        )
    )
