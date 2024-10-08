using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求扫荡 message
 */
public class ReqMopMessage : Message 
{
	//关卡难度id
	int _levelDifficultyId;	
	//扫荡次数
	int _num;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//关卡难度id
		SerializeUtils.WriteInt(stream, _levelDifficultyId);
		//扫荡次数
		SerializeUtils.WriteInt(stream, _num);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//关卡难度id
		_levelDifficultyId = SerializeUtils.ReadInt(stream);
		//扫荡次数
		_num = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 关卡难度id
	 */
	public int LevelDifficultyId
	{
		set { _levelDifficultyId = value; }
	    get { return _levelDifficultyId; }
	}
	
	/**
	 * 扫荡次数
	 */
	public int Num
	{
		set { _num = value; }
	    get { return _num; }
	}
	
	
	public override int GetId() 
	{
		return 102203;
	}
}