using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 后端返回请求开始战斗的结果 message
 */
public class ResStartAdvanceTrialBattleMessage : Message 
{
	//开始战斗是否成功[0:成功,1:等级不足,2:缺少角色,3:灵力修炼挑战次数不足,4:当前不可以攻打该关卡]
	int _status;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//开始战斗是否成功[0:成功,1:等级不足,2:缺少角色,3:灵力修炼挑战次数不足,4:当前不可以攻打该关卡]
		SerializeUtils.WriteInt(stream, _status);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//开始战斗是否成功[0:成功,1:等级不足,2:缺少角色,3:灵力修炼挑战次数不足,4:当前不可以攻打该关卡]
		_status = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 开始战斗是否成功[0:成功,1:等级不足,2:缺少角色,3:灵力修炼挑战次数不足,4:当前不可以攻打该关卡]
	 */
	public int Status
	{
		set { _status = value; }
	    get { return _status; }
	}
	
	
	public override int GetId() 
	{
		return 224101;
	}
}